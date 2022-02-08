using System;
using System.Threading.Tasks;

namespace ProgressTest.Lib
{
    public class Progress : IProgress
    {
        public event Action<int> ProgressChanged;
        
        public async Task Report(int value)
        {
            await Task.Run( () => ProgressChanged?.Invoke(value) );
        }
    }
}