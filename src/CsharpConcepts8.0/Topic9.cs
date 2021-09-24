using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CsharpConcepts8._0
{
    class Topic9
    {
        public void Entry()
        {
            Task.Run(async () =>
            {
                await using (var topic9Test = new Topic9Test())
                {
                    await topic9Test.WriteAsync("name", "shreesha");
                }
            }).Wait();

        }
    }

    class Topic9Test : IAsyncDisposable, IDisposable
    {
        private readonly MemoryStream _memoryStream = new MemoryStream();
        private Utf8JsonWriter _jsonWriter;

        public Topic9Test()
        {
            _jsonWriter = new Utf8JsonWriter(_memoryStream);
        }

        public async Task WriteAsync(string property, string value)
        {
            _jsonWriter.WriteStartObject();
            _jsonWriter.WriteString(property, value);
            _jsonWriter.WriteEndObject();
            await _jsonWriter.FlushAsync();
            Console.WriteLine(Encoding.UTF8.GetString(_memoryStream.ToArray()));
        }
        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore();

            Dispose(disposing: false);
            GC.SuppressFinalize(this);
        }
        protected virtual async ValueTask DisposeAsyncCore()
        {
            if (_jsonWriter is not null)
            {
                await _jsonWriter.DisposeAsync().ConfigureAwait(false);
            }
            _jsonWriter = null;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _jsonWriter?.Dispose();
            }

            _jsonWriter = null;
        }
    }
}
