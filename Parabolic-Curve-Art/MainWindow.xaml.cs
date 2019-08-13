using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Parabolic_Curve_Art
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			int originX = (int)Math.Floor(canvasArea.ActualWidth / 2);
			int originY = (int)Math.Floor(canvasArea.ActualHeight / 2);

			List<int> stepPoints = new List<int>();

			double lineThickness = 0.6;
			int lineCount = 50;
			int stepSize = 11;

			for (int i = 0; i <= lineCount; i++)
			{
				stepPoints.Add(i * stepSize);
			}

			for (int i = 0; i < lineCount; i++)
			{
				Line line1 = new Line();
				line1.StrokeThickness = lineThickness;
				line1.Stroke = Brushes.DodgerBlue;

				line1.X1 = originX - stepPoints[i];
				line1.Y1 = originY;

				line1.X2 = originX;
				line1.Y2 = originY - stepPoints[lineCount - 1 - i];

				canvasArea.Children.Add(line1);




				if (i > 0 && i < lineCount - 1)
				{

					Line line2 = new Line();
					line2.StrokeThickness = lineThickness;
					line2.Stroke = Brushes.DodgerBlue;

					line2.X1 = originX + stepPoints[i];
					line2.Y1 = originY;

					line2.X2 = originX;
					line2.Y2 = originY - stepPoints[lineCount - 1 - i];

					canvasArea.Children.Add(line2);

				}


				if (i > 0 && i < lineCount - 1)
				{
					Line line3 = new Line();
					line3.StrokeThickness = lineThickness;
					line3.Stroke = Brushes.DodgerBlue;

					line3.X1 = originX - stepPoints[i];
					line3.Y1 = originY;

					line3.X2 = originX;
					line3.Y2 = originY + stepPoints[lineCount - 1 - i];

					canvasArea.Children.Add(line3);
				}

				Line line4 = new Line();
				line4.StrokeThickness = lineThickness;
				line4.Stroke = Brushes.DodgerBlue;

				line4.X1 = originX + stepPoints[i];
				line4.Y1 = originY;

				line4.X2 = originX;
				line4.Y2 = originY + stepPoints[lineCount - 1 - i];

				canvasArea.Children.Add(line4);
			}
		}
	}
}
