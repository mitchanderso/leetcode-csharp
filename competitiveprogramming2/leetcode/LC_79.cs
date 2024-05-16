
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_79
    {
        
        List<Tuple<int, int>> directions = new List<Tuple<int, int>>{
            new Tuple<int, int>(0, 1),
            new Tuple<int, int>(0, -1),
            new Tuple<int, int>(1, 0),
            new Tuple<int, int>(-1, 0),

        };
        
        public bool Exist(char[][] board, string word)
        {
            int width = board[0].Length;
            int height = board.Length;
            var start = new List<Tuple<int, int>>();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (board[y][x] == word[0])
                    {
                        start.Add(new Tuple<int, int>(x, y));
                    }
                }
            }
            
            foreach (var (x, y) in start)
            {
                Console.WriteLine($"Starting from pos {x},{y}");
                var ans = dfs(board, x, y, word, 0);
                if (ans) return true;
            }

            return false;
        }

        public bool dfs(char[][] board, int x, int y, string word, int depth)
        {
            if (board[y][x] == '#')
            {
                return false;
            }
            if (depth == word.Length - 1)
            {
                return true;
            }
            int width = board[0].Length;
            int height = board.Length;
            char temp = board[y][x];
            board[y][x] = '#';
            Boolean found = false;
            foreach (var (xDisp, yDisp) in directions)
            {
                var newX = x + xDisp;
                var newY = y + yDisp;
                if (newX >= 0 && newX < width && newY < height && newY >= 0 && board[newY][newX] != '#' &&
                    board[newY][newX] == word[depth + 1])
                {
                    Console.WriteLine($"Can move to {newX},{newY} with value {board[newY][newX]}");
                    found = found || dfs(board, newX, newY, word, depth + 1);
                }
            }

            board[y][x] = temp;
            return found;
        }
    }


}

