# BackendCodingChallenge

Approach :

1. The number of watches in the request body is tracked using a dictionary
2. The dictionary is used by each watch class to get the discounted value
3. The total sum is returned

Class Structure

1. The dictionary is built by a static helper class
2. Base class holds three variables - unit price, group discount. group units
3. Base Watch class implements the calculation logic
4. Individual watch class overrides the method with their identifiers

Extensibility

There are two places that needs modifications when a new watch type is added
1. New watch class initialized with its unit price and discount details
2. Additional line in the controller for the new watch type

Scope for improvement

1. Unit price and discount details are hardcoded at class level. This is not recommended and needs to be moved to a config file
2. The discount calculation is sequential, this can be moved to parallel task via separate thread, which improves the performance
3. The total sum value will be updated by these tasks using lock mechanism
4. To avoid sending dictionary object to each discount calculator, using distributed caching will help here
5. When request has huge string array, building dictionary iteratively will hurt the performance
 
