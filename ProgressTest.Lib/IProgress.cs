using System;
using System.Threading.Tasks;

namespace ProgressTest.Lib
{
    public interface IProgress
    {
        public event Action<int> ProgressChanged;
        public Task Report(int value);
    }
}