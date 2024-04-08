using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.SequenceEqualIntegersQuery();
//var result = vm.SequenceEqualIntegersMethod();
//var result = vm.SequenceEqualObjectsQuery();
var result = vm.SequenceEqualObjectsMethod();

// Display Results
vm.Display(result);