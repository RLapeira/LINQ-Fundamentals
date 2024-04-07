using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.TakeQuery();
//var result = vm.TakeMethod();
//var result = vm.TakeRangeQuery();
//var result = vm.TakeRangeMethod();
//var result = vm.TakeWhileQuery();
//var result = vm.TakeWhileMethod();
//var result = vm.SkipQuery();
//var result = vm.SkipMethod();
//var result = vm.SkipWhileQuery();
var result = vm.SkipWhileMethod();

// Display Results
vm.Display(result);