using Academia.Entidades;
using Academia.Gestao;

var gestaoAlunos = new GestaoAluno();
var gestaoTreinamento = new GestaoTreinamento();
var planoTreinamento = new PlanoTreinamento();

int opcao;
string resposta;

do
{
    Console.Clear();
    Console.WriteLine(" ------------------------------");
    Console.Write("| ");
    Console.Write(" Menu principal da Academia : ");
    Console.WriteLine("| ");
    Console.WriteLine(" ------------------------------");

    Console.WriteLine("1. Cadastrar um novo aluno: ");
    Console.WriteLine("2. Montar treinamento: ");
    Console.WriteLine("3. Editar treinamento do aluno: ");
    Console.WriteLine("4. Exibir fixa de treinamento do aluno: ");
    Console.WriteLine("0. Sair: ");

    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.Clear();
            Console.WriteLine(" ---------------------- ");
            Console.Write("| ");
            Console.Write(" Cadastro de alunos: ");
            Console.WriteLine("| ");
            Console.WriteLine(" ---------------------- ");
            do
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine().ToUpper();
                Console.Write("Sexo: ");
                string sexo = Console.ReadLine().ToUpper();
                Console.Write("Data de Nascimento: ");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                var aluno = new Aluno(nome, sexo, dataNascimento);
                gestaoAlunos.CadastrarAluno(aluno);

                Console.WriteLine("Cadastrar mais alunos? (S/N) ");
            } while (Console.ReadLine().ToUpper().Equals("S"));
            break;

        case 2:
            Console.Clear();

            //criaçao do treinamento
            Console.WriteLine(" -------------------------- ");
            Console.Write("| ");
            Console.Write("Cadastro de treinamento: ");
            Console.WriteLine("| ");
            Console.WriteLine(" -------------------------- ");

            Console.Write("Nome do treinamento: ");
            string nomeTreinamento = Console.ReadLine().ToUpper();

            Console.Write("Duração do treinamento: ");
            string duracaoTreinamento = Console.ReadLine().ToUpper();

            var treinamento = new Treinamento(nomeTreinamento, duracaoTreinamento);

            //criação do treino
            Console.WriteLine("Quantos treinos deseja inserir em seu treinamento? ");
            int qtdeTreinos = int.Parse(Console.ReadLine());



            for (int t = 1; t <= qtdeTreinos; t++)
            {
                //criação dos exercicios 
                Console.WriteLine("Quantos exercicios você deseja adicionar ao seu treino? ");
                int qtdeExercicios = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do treino: ");
                string nomeTreino = Console.ReadLine().ToUpper();

                var treino = new Treino(nomeTreino);

                for (int e = 1; e <= qtdeExercicios; e++)
                {
                    Console.Write($"Nome do {e}º exercicio: ");
                    string nomeExercicio = Console.ReadLine().ToUpper();

                    Console.Write("Grupo muscular em foco: ");
                    string grupoMuscular = Console.ReadLine().ToUpper();

                    Console.Write("Número de séries: ");
                    int numeroSeries = int.Parse(Console.ReadLine());

                    Console.Write("Número de repetições: ");
                    int numeroRepeticoes = int.Parse(Console.ReadLine());

                    var exercicio = new Exercicio(nomeExercicio, grupoMuscular, numeroSeries, numeroRepeticoes);

                    treino.CadastrarExercicio(exercicio);
                }
                treinamento.CadastrarTreino(treino);
                Console.WriteLine();
            }
            planoTreinamento.CadastrarTreinamento(treinamento);


            foreach (var planTreinamento in planoTreinamento.Treinamentos)
            {
                Console.WriteLine($"\n \nNome: {planTreinamento.Nome} \nDuração: {planTreinamento.Duracao}");
                foreach (var trein in planTreinamento.Treinos)
                {
                    Console.WriteLine($"Nome do treino: {trein.Nome}");
                    foreach (var exerc in trein.Exercicios)
                    {
                        Console.WriteLine($"\nNome exercicio: {exerc.Nome}  || Grupo muscular: {exerc.GrupoMuscular} || Séries: {exerc.Series} || Repetições: {exerc.Repeticoes}   ");
                    }
                }
            }
            break;

        case 3:
            //mostrando só o ultimo inserido 
            Console.Clear();
            Console.WriteLine(" ----------------------------- ");
            Console.Write("| ");
            Console.Write("Lista de alunos cadastrados: ");
            Console.WriteLine("| ");
            Console.WriteLine(" ----------------------------- ");

            foreach (var alunoCadastrado in gestaoAlunos.ListaAlunos)
            {
                Console.WriteLine($"Nome: {alunoCadastrado.Nome} \nSexo: {alunoCadastrado.Sexo} \nData de Nascimento: {alunoCadastrado.DataNascimento}");
            }
            Console.WriteLine("Quantidade de alunos cadastrados: " + gestaoAlunos.ListaAlunos.Count);
            do
            {

                Console.Write("Digite o nome do aluno que deseja alterar o treino: ");
                var nomeAluno = Console.ReadLine().ToUpper();
                if()


                Console.WriteLine("Continuar: (S/N) ");
            } while (Console.ReadLine().ToUpper().Equals("S"));
            break;

        case 4:
            Console.Clear();
            Console.WriteLine(" ----------------------------- ");
            Console.Write("| ");
            Console.Write("Ficha treinamento ");
            Console.WriteLine("| ");
            Console.WriteLine(" ----------------------------- ");

            break;

        default:
            Console.WriteLine("Operação inválida");
            break;
    }
    Console.WriteLine("Deseja continuar? (S/N)");
    resposta = Console.ReadLine().ToUpper();

} while (resposta.Equals("S"));
    