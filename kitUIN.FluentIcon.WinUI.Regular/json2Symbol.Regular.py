import json
from typing import Dict

file = "FluentSystemIcons-Regular.json"
res_file = "FluentRegularIconSymbol.cs"
symbols: Dict[str,int] = dict()
res = ["""namespace FluentIcon.WinUI
{
    /// <summary>
    /// 图标枚举<br/>
    /// From json2Symbol.Regular.py<br/>
    /// Font Version: 1.1.224<br/>
    /// Json File Path:<seealso cref="https://github.com/microsoft/fluentui-system-icons/blob/main/fonts/FluentSystemIcons-Regular.json"/>
    /// </summary>
    public enum FluentRegularIconSymbol
    {
"""]
with open(file,"r+") as f:
    symbols = json.loads(f.read())
# print(symbols)
for key,value in symbols.items():
    string = key.replace("ic_fluent_","")
    new_string = ""
    for word in string.split("_"):
        new_string += word.capitalize()
    res.append(f'        {new_string} = {value},\n')
res.append("""    }
}
""")
print(res_file)
with open(res_file,"w+") as f:
    f.writelines(res)