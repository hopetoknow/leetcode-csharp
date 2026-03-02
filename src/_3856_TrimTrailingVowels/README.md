# [3856. Trim Trailing Vowels](https://leetcode.com/problems/trim-trailing-vowels)

## Description

<p>You are given a string <code>s</code> that consists of lowercase English letters.</p>

<p>Return the string obtained by removing <strong>all</strong> trailing <strong>vowels</strong> from <code>s</code>.</p>

<p>The <strong>vowels</strong> consist of the characters <code>'a'</code>, <code>'e'</code>, <code>'i'</code>, <code>'o'</code>, and <code>'u'</code>.</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<div class="example-block">
<p><strong>Input:</strong> <span class="example-io">s = "idea"</span></p>

<p><strong>Output:</strong> <span class="example-io">"id"</span></p>

<p><strong>Explanation:</strong></p>

<p>Removing <code>"id<u><strong>ea</strong></u>"</code>, we obtain the string <code>"id"</code>.</p>
</div>

<p><strong class="example">Example 2:</strong></p>

<div class="example-block">
<p><strong>Input:</strong> <span class="example-io">s = "day"</span></p>

<p><strong>Output:</strong> <span class="example-io">"day"</span></p>

<p><strong>Explanation:</strong></p>

<p>There are no trailing vowels in the string <code>"day"</code>.</p>
</div>

<p><strong class="example">Example 3:</strong></p>

<div class="example-block">
<p><strong>Input:</strong> <span class="example-io">s = "aeiou"</span></p>

<p><strong>Output:</strong> <span class="example-io">""</span></p>

<p><strong>Explanation:</strong></p>

<p>Removing <code>"<u><strong>aeiou</strong></u>"</code>, we obtain the string <code>""</code>.</p>
</div>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>1 &lt;= s.length &lt;= 100</code></li>
	<li><code>s</code> consists of only lowercase English letters.</li>
</ul>
