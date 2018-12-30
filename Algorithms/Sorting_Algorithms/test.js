// function FindLargestSubString(s1, s2) {
//   if (s1.length === 0 || s2.length === 0) return 0;
//   if (
//     typeof s1 !== "string" ||
//     typeof s2 !== "string" ||
//     typeof s1 !== typeof s2
//   )
//     return "Both inputs should be Strings";

//   let str = s1.length >= s2.length ? compare(s1, s2) : compare(s2, s1);
//   let s = str[0];
//   for (let i = 1; i < str.length; i++) {
//     if (s.length < str[i].length) {
//       s = "";
//       s = str[i];
//     }
//   }

//   return s;
// }

// function compare(s1, s2) {
//   let result = "";
//   let index = 0;
//   let count;
//   let strArray = [];

//   for (let i = 0; i < s2.length; i++) {
//     count = 0;
//     for (let j = i; j < s2.length; j++) {
//       index = count;
//       while (index < s1.length) {
//         if (s2[j] === s1[index]) {
//           result += s2[j];
//           count = ++index;
//           break;
//         }
//         index++;
//       }
//     }
//     strArray.push(result);
//     result = "";
//   }
//   return strArray;
// }

// let s1 = "AGGTAB";
// let s2 = "GXTXAYB";

// let x = s1.includes(s2);
// console.log(FindLargestSubString(s1, s2));

console.log(Number.MAX_VALUE);
