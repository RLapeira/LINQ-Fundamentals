using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.ForEachQuery();
var result = vm.ForEachMethod();

// Display Results
vm.Display(result);