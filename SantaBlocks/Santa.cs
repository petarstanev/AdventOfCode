using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaBlocks
{
    public enum Direction
    {
        North = 0, East = 1, South = 2, West = 3
    }

    public class Santa
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction;

        public Santa()
        {
            X = 0;
            Y = 0;
            Direction = Direction.North;
        }

        public void Move(char rotate, int moves)
        {
            ChangeDirection(rotate);
            MoveBlocks(moves);
        }

        private void MoveBlocks(int moves)
        {
            switch (Direction)
            {
                case Direction.North:
                    Y += moves;
                    break;
                case Direction.South:
                    Y -= moves;
                    break;
                case Direction.East:
                    X += moves;
                    break;
                case Direction.West:
                    X -= moves;
                    break;
            }
        }

        private void ChangeDirection(char rotate)
        {
            int directionInt = (int)Direction;

            if (rotate == 'R')
            {
                if (directionInt == 3)
                {
                    directionInt = 0;
                }
                else
                {
                    directionInt++;
                }
            }
            else
            {
                if (directionInt == 0)
                {
                    directionInt = 3;
                }
                else
                {
                    directionInt--;
                }
            }
            Direction = (Direction)directionInt;
        }

        public int BlocksAway()
        {
            int blocksX, blocksY;
            blocksX = GeneratePositiveNumber(X);
            blocksY = GeneratePositiveNumber(Y);
            return blocksX + blocksY;
        }

        private int GeneratePositiveNumber(int input)
        {
            if (input < 0)
            {
                input = input * -1;
            }

            return input;
        }

        public void SetUpRoad(string road)
        {
            string[] moves;
            road = road.Replace(" ", string.Empty);
            moves = road.Split(',');

            foreach (string move in moves)
            {
                char letter = move[0];

                int number = Int32.Parse(move.Substring(1));
                Move(letter, number);
            }
        }
    }
}
