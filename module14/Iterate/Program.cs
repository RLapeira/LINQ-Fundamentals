using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.ForEachQuery();
//var result = vm.ForEachMethod();
//var result = vm.ForEachSubQueryQuery();
//var result = vm.ForEachSubQueryMethod();
//var result = vm.ForEachQueryCallingMethodQuery();
//var result = vm.ForEachQueryCallingMethod();
var result = vm.ForEachQueryCalculateNameLength();

// Display Results
vm.Display(result);