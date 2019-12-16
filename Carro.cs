class Carro
    {

        private string _Cor;
        private string _Ano;
        private string _Modelo;

        public string GetCor ()
        {
            return _Cor;
        }

        public string GetAno()
        {
            return _Ano;
        }

        public string GetModelo()
        {
            return _Modelo;
        }

        public void SetCor (string Cor)
        {
            _Cor = Cor;
        }

        public void SetAno(string Ano)
        {
            _Ano = Ano;
        }

        public void SetModelo(string Modelo)
        {
            _Modelo = Modelo;
        }

        public Carro()
        {
            _Cor = "Não possui informação de cor";
            _Ano = "Não possui informação de ano";
            _Modelo = "Não possui informação de modelo";

        }

        public Carro (string modelo, string cor, string ano)
        {
            _Cor = cor;
            _Ano = ano;
            _Modelo = modelo;


        }

        


    }