# [3823. Reverse Letters Then Special Characters in a String](https://leetcode.com/problems/reverse-letters-then-special-characters-in-a-string)

## Description

<p>You are given a string <code>s</code> consisting of lowercase English letters and special characters.</p>

<p>Your task is to perform these <strong>in order</strong>:</p>

<ul>
	<li><strong>Reverse</strong> the <strong>lowercase letters</strong> and place them back into the positions originally occupied by letters.</li>
	<li><strong>Reverse</strong> the <strong>special characters</strong> and place them back into the positions originally occupied by special characters.</li>
</ul>

<p>Return the resulting string after performing the reversals.</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<div class="example-block">
<p><strong>Input:</strong> <span class="example-io">s = "</span>)ebc#da@f(<span class="example-io">"</span></p>

<p><strong>Output:</strong> <span class="example-io">"</span>(fad@cb#e)<span class="example-io">"</span></p>

<p><strong>Explanation:</strong></p>

<ul>
	<li>The letters in the string are <code>['e', 'b', 'c', 'd', 'a', 'f']</code>:

	<ul>
		<li>Reversing them gives <code>['f', 'a', 'd', 'c', 'b', 'e']</code></li>
		<li><code>s</code> becomes <code>")fad#cb@e("</code></li>
	</ul>
	</li>
	<li>​​​​​​​The special characters in the string are <code>[')', '#', '@', '(']</code>:
	<ul>
		<li>Reversing them gives <code>['(', '@', '#', ')']</code></li>
		<li><code>s</code> becomes <code><span class="example-io">"</span>(fad@cb#e)<span class="example-io">"</span></code></li>
	</ul>
	</li>
</ul>
</div>

<p><strong class="example">Example 2:</strong></p>

<div class="example-block">
<p><strong>Input:</strong> <span class="example-io">s = "z"</span></p>

<p><strong>Output:</strong> <span class="example-io">"z"</span></p>

<p><strong>Explanation:</strong></p>

<p>The string contains only one letter, and reversing it does not change the string. There are no special characters.</p>
</div>

<p><strong class="example">Example 3:</strong></p>

<div class="example-block">
<p><strong>Input:</strong> <span class="example-io">s = "!@#$%^&amp;*()"</span></p>

<p><strong>Output:</strong> <span class="example-io">"</span>)(*&amp;^%$#@!<span class="example-io">"</span></p>

<p><strong>Explanation:</strong></p>

<p>The string contains no letters. The string contains all special characters, so reversing the special characters reverses the whole string.</p>
</div>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>1 &lt;= s.length &lt;= 100</code></li>
	<li><code>s</code> consists only of lowercase English letters and the special characters in <code>"!@#$%^&amp;*()"</code>.</li>
</ul>
