using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    /*
     * метод void SetStart(int x) - устанавливает начальное значение
     метод int GetNext() - возвращает следующее число ряда
     метод void Reset() - выполняет сброс к начальному значению
     */
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;
        public int GetNext()
        {
            currentValue+=step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue=x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
    class GeoProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;
        public int GetNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
