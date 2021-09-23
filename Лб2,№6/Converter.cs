using System;

namespace Лб2__6
{
    class Converter
    {
        private double _usdToUah, _eurToUah, _rubToUah;
        private double _usd, _eur, _rub, _uah;

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _usdToUah = Math.Round(_usd * 26.69, 2);

            _eur = eur;
            _eurToUah = Math.Round(_eur * 31.29, 2);

            _rub = rub;
            _rubToUah = Math.Round(_rub * 0.37, 2);
        }

        public Converter(double uah)
        {
            _uah = uah;
            _usd = Math.Round(_uah / 26.69, 2);
            _eur = Math.Round(_uah / 31.29, 2);
            _rub = Math.Round(_uah / 0.37, 2);
        }

        public void InfoCurrToUah()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_usd}$ = {_usdToUah}₴");
            Console.WriteLine($"{_eur}€ = {_eurToUah}₴");
            Console.WriteLine($"{_rub}₱ = {_rubToUah}₴");
            Console.ResetColor();
        }

        public void InfoUahToCurr()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_uah}₴ = {_usd}$");
            Console.WriteLine($"{_uah}₴ = {_eur}€");
            Console.WriteLine($"{_uah}₴ = {_rub}₱");
            Console.ResetColor();
        }
    }
}
