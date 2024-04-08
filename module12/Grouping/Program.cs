using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.GroupByQuery();
//var result = vm.GroupByMethod();
//var result = vm.GroupByUsingKeyQuery();
var result = vm.GroupByUsingKeyMethod();

// Display Results
vm.Display(result);