using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.TakeQuery();
//var result = vm.TakeMethod();
//var result = vm.TakeRangeQuery();
//var result = vm.TakeRangeMethod();
//var result = vm.TakeWhileQuery();
var result = vm.TakeWhileMethod();

// Display Results
vm.Display(result);