
namespace P03_JediGalaxy
{
    public class JedyGalaxyMatrix
    {

        private int[,] galaxyMatrix;
        private int ivoCoordinateX;
        private int ivoCoordianteY;
        private int enemyCoordinateX;
        private int enemyCoordianteY;
        private int sum;

        public JedyGalaxyMatrix(int dimentionX, int dimentionY)
        {
            this.GalaxyMatrix(dimentionX, dimentionY);
            this.sum = 0;
        }

        public int IvoCoordinateX
        {
            set
            {
                this.ivoCoordinateX = value;
            }

        }

        public int IvoCoordianteY
        {
            set
            {
                this.ivoCoordianteY = value;
            }
        }

        public int EnemyCoordinateX
        {
            set
            {
                this.enemyCoordinateX = value;
            }
        }

        public int EnemyCoordinateY
        {
            set
            {
                this.enemyCoordianteY = value;
            }
        }

        void GalaxyMatrix(int tempDimentionX, int tempDimentionY)
        {
            this.galaxyMatrix = new int[tempDimentionX, tempDimentionY];
            int value = 0;
            for (int i = 0; i < tempDimentionX; i++)
            {
                for (int j = 0; j < tempDimentionY; j++)
                {
                    this.galaxyMatrix[i, j] = value++;
                }
            }
        }


        public void RemoveEnemyPath()
        {
            while (enemyCoordinateX >= 0 && enemyCoordianteY >= 0)
            {
                if (enemyCoordinateX >= 0 && enemyCoordinateX < galaxyMatrix.GetLength(0) &&
                    enemyCoordianteY >= 0 && enemyCoordianteY < galaxyMatrix.GetLength(1))
                {
                    galaxyMatrix[enemyCoordinateX, enemyCoordianteY] = 0;
                }
                enemyCoordinateX--;
                enemyCoordianteY--;
            }
        }

        public void CalculateSumPathIvo()
        {
            while (ivoCoordinateX >= 0 && enemyCoordianteY < galaxyMatrix.GetLength(1))
            {
                if (ivoCoordinateX >= 0 && ivoCoordinateX < galaxyMatrix.GetLength(0) &&
                    ivoCoordianteY >= 0 && ivoCoordianteY < galaxyMatrix.GetLength(1))
                {
                    this.sum += galaxyMatrix[ivoCoordinateX, ivoCoordianteY];
                }

                ivoCoordianteY++;
                ivoCoordinateX--;
            }
        }

        public void setIvoCoordinate(int tempIvoXCoordinate, int tempIvoYCoordiante)
        {
            this.IvoCoordinateX = tempIvoXCoordinate;
            this.IvoCoordianteY = tempIvoYCoordiante;
        }

        public void setEnemyCoordinate(int tempEnemyXCoordiante, int tempEnemyYCoordinate)
        {
            this.EnemyCoordinateX = tempEnemyXCoordiante;
            this.EnemyCoordinateY = tempEnemyYCoordinate;
        }

        public long GetResult()
        {
            return this.sum;
        }
    }
}
