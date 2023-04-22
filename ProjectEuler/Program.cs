using System.Diagnostics;

using ProjectEuler;

var watch = new Stopwatch();

watch.Start();

Problem0011.run();

watch.Stop();

TimeSpan ts = watch.Elapsed;

string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

Console.WriteLine($"Execution Time: " + elapsedTime);