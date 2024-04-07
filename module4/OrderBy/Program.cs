using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.OrderByQuery();
var result = vm.OrderByMethod();

// Display Results
vm.Display(result);