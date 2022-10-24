using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入身高：");
			string inputCM=Console.ReadLine();

			Console.Write("請輸入體重：");
			string inputKG=Console.ReadLine();

			bool isHeight = double.TryParse(inputCM, out double height);
			if (isHeight == false)
			{
				Console.WriteLine("請輸入數字");
				return;
			}
			if (height <= 0)
			{
				Console.WriteLine("請輸入大於0的數字");
				return ;
			}

			bool isWeight = double.TryParse(inputKG, out double weight);
			if (isWeight == false)
			{
				Console.WriteLine("請輸入數字");
				return;
			}
			if (weight <= 0)
			{
				Console.WriteLine("請輸入大於0的數字");
				return;
			}


			double heightM = height / 100;
			double heightMM = Math.Pow(heightM,2);
			
			double bmi = weight/heightMM;
			Console.WriteLine(bmi.ToString(".00"));
		}
	}
}
