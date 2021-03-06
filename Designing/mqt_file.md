# MQT 模板文件

将指定格式的题目模板打包成.zip压缩文件，拓展名改为.mqt，即可放入template文件夹被程序识别加载

## 选择题格式

- 源信息文件（`metadata.yml`），注明模板的题目类型和名称
  - `name`为模板显示的名称；
  - `type`为模板类型，可选`choice`选择题、`fillingblanks`填空题、`calculation`计算题
- 题干文件（`question_stem.txt`）
  - 每行为一种题干形式；第一行为通用样式，其余为情景样式（每种只会出现一次）；
  - 计算题则只会识别第一行，且应当仅包含数学公式；
  - 题干中可以使用`#{条件ID}`的格式引用生成的条件；
  - 支持Markdown格式文本（包含LaTeX数学公式）；
- script文件夹，定义生成脚本
  - `condition`生成题目条件
  - `option`生成选项（`answer.js`生成答案，`interference.js`生成干扰选项

### 条件创建脚本

文件名即为条件ID。返回一个字符串或实数作为条件。

### 选项生成脚本

`answer.js`生成正确答案（在脚本中使用`condition`对象来访问条件），返回一个实数或字符串。

`interference.js`生成其他的干扰选项（在脚本中使用`condition`对象来访问条件，`answer`变量访问已经生成的正确答案，可以使用随机库产生随机数），返回一个实数或字符串。
