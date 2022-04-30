using System;
//using System.Linq;

namespace Tic_Tac_Toe {
    class Program {            
        static void Main(string[] args) {
            char[] grid = create_grid();
            int i = 0;
            bool game_over = false;
            bool game = game_loop(grid, i, game_over);
            if (game == false) {
                Console.WriteLine("The game is a draw!");
                Console.WriteLine();
                Console.Write(" " + grid[0]);
                Console.Write(" | " + grid[1]);
                Console.WriteLine(" | " + grid[2]);
                Console.WriteLine("---+---+---");
                Console.Write(" " + grid[3]);
                Console.Write(" | " + grid[4]);
                Console.WriteLine(" | " + grid[5]);
                Console.WriteLine("---+---+---");
                Console.Write(" "  + grid[6]);
                Console.Write(" | " + grid[7]);
                Console.WriteLine(" | " + grid[8]);
                }   
        }
        static bool game_loop(char[] grid, int i, bool game_over) {
            for(i = 0; i < 9; i++) {
                char[] player_turn = new char[] {'X','O','X','O','X','O','X','O','X'};
                Console.Write(" " + grid[0]);
                Console.Write(" | " + grid[1]);
                Console.WriteLine(" | " + grid[2]);
                Console.WriteLine("---+---+---");
                Console.Write(" " + grid[3]);
                Console.Write(" | " + grid[4]);
                Console.WriteLine(" | " + grid[5]);
                Console.WriteLine("---+---+---");
                Console.Write(" "  + grid[6]);
                Console.Write(" | " + grid[7]);
                Console.WriteLine(" | " + grid[8]);
                Console.WriteLine("Player "+ player_turn[i] +" Pick a position");
                int PlayerChoice = int.Parse(Console.ReadLine());
                edit_grid(grid, player_turn[i], PlayerChoice);
                game_over = check_winner(grid);
                if (game_over == true) {
                    Console.WriteLine("Player: " + player_turn[i] + " Wins!");
                    i = 9;
                    Console.Write(" " + grid[0]);
                    Console.Write(" | " + grid[1]);
                    Console.WriteLine(" | " + grid[2]);
                    Console.WriteLine("---+---+---");
                    Console.Write(" " + grid[3]);
                    Console.Write(" | " + grid[4]);
                    Console.WriteLine(" | " + grid[5]);
                    Console.WriteLine("---+---+---");
                    Console.Write(" "  + grid[6]);
                    Console.Write(" | " + grid[7]);
                    Console.WriteLine(" | " + grid[8]);
                }  
            } return game_over;
        }
        static char[] create_grid() {
            char[] grid = new char[]{'1','2','3','4','5','6','7','8','9'};
            return grid;    
        }
        static char[] edit_grid(char[] gridToEdit, char player, int grid_index) {
            gridToEdit[grid_index-1] = player;
            char[] edited_grid = gridToEdit;
            return edited_grid;
        }
        static bool check_winner(char[] gridToCheck) {
            bool winner;
            if((gridToCheck[0]== 'X' && gridToCheck[1] == 'X' && gridToCheck[2] == 'X') || // win condition 1
               (gridToCheck[3]== 'X' && gridToCheck[4] == 'X' && gridToCheck[5] == 'X') || // win condition 2
               (gridToCheck[6]== 'X' && gridToCheck[7] == 'X' && gridToCheck[8] == 'X') || // win condition 3
               (gridToCheck[0]== 'X' && gridToCheck[3] == 'X' && gridToCheck[6] == 'X') || // win condition 4
               (gridToCheck[1]== 'X' && gridToCheck[4] == 'X' && gridToCheck[7] == 'X') || // win condition 5
               (gridToCheck[2]== 'X' && gridToCheck[5] == 'X' && gridToCheck[8] == 'X') || // win condition 6
               (gridToCheck[0]== 'X' && gridToCheck[4] == 'X' && gridToCheck[8] == 'X') || // win condition 7
               (gridToCheck[2]== 'X' && gridToCheck[4] == 'X' && gridToCheck[6] == 'X'))   // win condition 8
               {
                   winner = true;
               } else if ((gridToCheck[0]== 'O' && gridToCheck[1] == 'O' && gridToCheck[2] == 'O') || // win condition 1
                          (gridToCheck[3]== 'O' && gridToCheck[4] == 'O' && gridToCheck[5] == 'O') || // win condition 2
                          (gridToCheck[6]== 'O' && gridToCheck[7] == 'O' && gridToCheck[8] == 'O') || // win condition 3
                          (gridToCheck[0]== 'O' && gridToCheck[3] == 'O' && gridToCheck[6] == 'O') || // win condition 4
                          (gridToCheck[1]== 'O' && gridToCheck[4] == 'O' && gridToCheck[7] == 'O') || // win condition 5
                          (gridToCheck[2]== 'O' && gridToCheck[5] == 'O' && gridToCheck[8] == 'O') || // win condition 6
                          (gridToCheck[0]== 'O' && gridToCheck[4] == 'O' && gridToCheck[8] == 'O') || // win condition 7
                          (gridToCheck[2]== 'O' && gridToCheck[4] == 'O' && gridToCheck[6] == 'O')) {  // win condition 8 
                              winner = true;
                          } else { 
                              winner = false;
                          }            
            return winner;
        }
     }
}
