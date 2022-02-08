using System.Threading.Tasks;
using ProgressTest.Lib;

namespace ProgressTest.Lib2
{
    public class Calculate
    {
        private IProgress _progress;

        public Calculate(IProgress progress)
        {
            _progress = progress;
        }

        public async Task<int> Factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            { 
                fact = num;
                for (int i = fact - 1; i > 0; i--)
                {
                    fact *= i;
                }
                await _progress.Report(fact);
                num--;
            }

            return fact;
        }
    }
}