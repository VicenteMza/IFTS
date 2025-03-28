namespace Semana2
{
    internal class SuperHeroe
    {
        private string _name;
        //fuerza
        private int _strength;
        private int _resistance;
        private int _superPower;

        public SuperHeroe(string name, int strength, int resistance, int superPower)
        {
            _name = name;
            _strength = ValidateNumbers(strength);
            _resistance = ValidateNumbers(resistance);
            _superPower = ValidateNumbers(superPower);
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Strength
        {
            get => _strength;
            set => _strength = ValidateNumbers(value);
        }
        public int Resistance
        {
            get => _resistance;
            set => _resistance = ValidateNumbers(value);
        }
        public int SuperPower
        {
            get => _superPower;
            set => _superPower = ValidateNumbers(value);
        }

        private int ValidateNumbers(int value)
        {
            return value < 0 ? 0 : value > 100 ? 100 : value;
        }

        public string Compete(SuperHeroe otherHeroe)
        {
            // Se compara el puntaje (strength, resistance, superPower) con el otro héroe.
            // Se asigna 1 punto si este héroe tiene un puntaje mayor.
            // Se asigna -1 punto si este héroe tiene un puntaje menor.
            // Se asigna 0 puntos si los puntajes son iguales.
            int points =
                (Resistance > otherHeroe.Resistance ? 1 : Resistance == otherHeroe.Resistance ? 0 : -1) +
                (Strength > otherHeroe.Strength ? 1 : Strength == otherHeroe.Strength ? 0 : -1) +
                (SuperPower > otherHeroe.SuperPower ? 1 : SuperPower == otherHeroe.SuperPower ? 0 : -1);

            return points > 0 ? "TRIUNFO" : points < 0 ? "DERROTA" : "EMPATE";
        }
    }
}