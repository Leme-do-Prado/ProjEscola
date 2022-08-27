namespace projEscola{
    class Curso{
        private int id;
        private string descricao;
        private disciplina[12] disciplinas;

        public int Id{
            get {return id;}
            set {id = value;}
        }

        public string Descricao{
            get {return descricao;}
            set {descricao = value;}
        }

        public disciplina Disciplinas{
            get {return disciplinas;}
            set {disciplinas = value;}
        }

        public bool adicionarDisciplina{

        }

        public bool removerDisciplina{
            
        }

        public Disciplina pesquisarDisciplina{
            
        }
    }
}
