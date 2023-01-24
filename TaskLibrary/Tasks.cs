using System;
using System.Data;
using System.Windows.Documents;

namespace TaskLibrary
{
    public class Tasks
    {
        /// <summary>
        /// #1 ������ ���������� �����. ����������: ������� �� ��� ������ �� �������� ����.
        /// </summary>
        /// <param name="DoubleDigit"> ���������� �����</param>
        /// <returns></returns>
        public static bool DoubleDigitNotEven(int DoubleDigit)
        {
            if ((DoubleDigit % 10) % 2 != 0)
            {
                if ((DoubleDigit / 10) % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// #2 ������ ��� ����� �����. ����� ����� ���� ���������� �� ���.
        /// </summary>
        /// <param name="TripleDigit"></param>
        /// <returns></returns>
        public static int TripleDigitSumm(int First, int Second, int Third)
        {
            if ((First <= Second & Second < Third) || (Second <= First & First < Third))
            {
                return First + Second;
            }
            if ((Second <= Third & Third < First) || (Third <= Second & Second < First))
            {
                return Second + Third;
            }
            if ((Third <= First & First < Second) || (First <= Third & Third < Second))
            {
                return Third + First;
            }
            if (First == Second & Second < Third) { return First + Second; }
            if (First == Second & Second > Third) { return First + Third; }
            else if (Second == Third & Third < First) { return Second + Third; }
            else if (Second == Third & Third > First) { return Second + First; }
            if (First == Third & Third < Second) { return First + Third; }
            { return First + Second; }
        }

        /// <summary>
        /// #3 ��� ������ ����� �����. ����� ����� ������� ��������� ��������. ���� �������� ��������� � ������� ���, �� �������� �� ����.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int ArrayFirstNotEven(int[] array)
        {
            int i = 0;

            do
            {
                if (array[i] % 2 != 0)
                {
                    return i;
                }
                i++;
            }
            while (i < array.Length);

            return -1;
        }

        /// <summary>
        /// #4 ������������ ���������� ������ �� ���� ��������� �������� �������.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[] MatrixSummOfColumns(int[,] matrix)
        {
            int[] array = new int[matrix.GetLength(1)];
            int summ = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    summ += matrix[j, i];
                }
                array[i] = summ;
                summ = 0;
            }
            return array;
        }
    }
}
