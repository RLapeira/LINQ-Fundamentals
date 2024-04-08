using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.DeferredExecution();
//var result = vm.DeferredExecutionEnumerator();
//var result = vm.UsingWhereAndTake();
//var result = vm.UsingSimpleFilter();
//var result = vm.UsingSimpleFilterAndTake();
//var result = vm.UsingYield();
//var result = vm.UsingYieldAndTake();
var result = vm.UsingYieldAndOrderBy();

// Display Results
vm.Display(result);