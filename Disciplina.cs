namespace ProjEscola{
    class Disciplina{
      private int id;
      private string descricao;
      private Aluno[15] alunos;

      public int Id{
          get {return id;}
          set {id = value;}
      }  

      public string Descricao{
          get {return descricao;}
          set {descricao = value;}
      }

      public Aluno alunos{
          get {return alunos;}
          set {alunos = value;}
      }

      public bool matricularAluno(Aluno aluno){

      }

      public bool desmatricularAluno(Aluno aluno){
          
      }
    }
}
