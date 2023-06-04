import json
from typing import Dict

file = "FluentSystemIcons-Resizable.json"
res_file = "FluentIcon/FluentIconSymbol.cs"
symbols: Dict[str,int] = dict()
res = ["""namespace FluntIcon
{
    /// <summary>
    /// 图标枚举<br/>
    /// From json2Symbol.py<br/>
    /// Font Version: 1.1.203<br/>
    /// Json File Path:<seealso cref="https://github.com/microsoft/fluentui-system-icons/blob/main/fonts/FluentSystemIcons-Resizable.json"/>
    /// </summary>
    public enum FluentIconSymbol
    {
"""]
with open(file,"+rb") as f:
    symbols = json.loads(f.read())
#print(symbols)
for key,value in symbols.items():
    string = key.replace("ic_fluent_","")
    new_string = ""
    for word in string.split("_"):
        if word == "20":
            continue
        new_string += word.capitalize()
    res.append(f'        {new_string} = \'\\u{hex(value)[2:].upper()}\',\n')
res.append("""    }
}
""")
with open(res_file,"w") as f:
    f.writelines(res)