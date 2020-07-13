# Summary

---

Sample project to demonstrate the following Bug:

- When a field is once in a fragment with @include(if:false) and once outside of that fragment, the field is not returned by the HotChocolate API.

# Steps to reproduce

---

- Run the Demo Api from this repository
- Perform the following Query

'''
{
alphaWithFragment: alpha {
\_\_typename
...f @include(if: true)
}

alphaWithoutFragment: alpha {
\_\_typename
...f @include(if: false)
}
}

fragment f on Abc {
foo
\_\_typename
}
'''

# Expected result

---

In the JSON Result, alphaWithoutFragment should contain a field "\_\_typename".

# Actual result

---

![it doesn't](/images/actual-result.jpg)
