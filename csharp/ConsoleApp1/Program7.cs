//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//
//
////enum com switch
//namespace HelloWorld{
//    class Program7{
//
//        enum Cor {Azul, Verde, Amarelo, Vermelho}
//        enum opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
//
//        static void Main(string[]args)
//        {
//            Console.WriteLine("Selecione uma das opções abaixo: ");
//            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
//            int index = int.Parse(Console.ReadLine());
//            opcao opcaoSelecionada = (opcao)index;
//
//            
//
//            switch (opcaoSelecionada){
//                case opcao.Criar:
//                    Console.WriteLine("Você quer criar algo!");
//                    break;
//                case opcao.Deletar:
//                    Console.WriteLine("Delete! Delete Imediatamente!");
//                    break;
//                case opcao.Editar:
//                    Console.WriteLine("Editar e muito bom!");
//                    break;
//                default:
//                    Console.WriteLine("Opção não encontrada!");
//                    break;
//                
//
//            }
//            
//            
//            /*Cor corFavorita = Cor.Amarelo;
//            Cor corFavoritaDaCarla= Cor.Azul;
//
//            Console.WriteLine((int)corFavorita);
//            Console.WriteLine((Cor)2);
//            Console.WriteLine(corFavoritaDaCarla);*/
//
//            Console.ReadLine();
//        }
//
//        
//
//    }
//    
//}