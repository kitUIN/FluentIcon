import json
from typing import Dict

file = "FluentSystemIcons-Filled.json"
res_file = "FluentFilledIconSymbol.cs"
symbols: Dict[str,int] = dict()
res = ["""namespace FluentIcon.WinUI
{
    /// <summary>
    /// 图标枚举<br/>
    /// From json2Symbol.Filled.py<br/>
    /// Font Version: 1.1.224<br/>
    /// Json File Path:<seealso cref="https://github.com/microsoft/fluentui-system-icons/blob/main/fonts/FluentSystemIcons-Filled.json"/>
    /// </summary>
    public enum FluentFilledIconSymbol
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
with open(res_file,"w") as f:
    f.writelines(res)