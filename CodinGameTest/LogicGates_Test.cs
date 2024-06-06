using CodinGame.Fini;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace CodinGameTest
{
    public class LogicGates_Test
    {
        [Fact]
        public void Cas1()
        {
            var input = new Input()
            {
                n = 2,
                m = 3,
                inputName = ["A", "B"],
                inputSignal = ["__---___---___---___---___", "____---___---___---___---_"],
                outputName = ["C", "D", "E"],
                type = ["AND", "OR", "XOR"],
                inputName1 = ["A", "A", "A"],
                inputName2 = ["B", "B", "B"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("C ____-_____-_____-_____-___", stringOutput[0]);
            Assert.Equal("D __-----_-----_-----_-----_", stringOutput[1]);
            Assert.Equal("E __--_--_--_--_--_--_--_--_", stringOutput[2]);
        }

        [Fact]
        public void Cas2()
        {
            var input = new Input()
            {
                n = 1,
                m = 1,
                inputName = ["A"],
                inputSignal = ["__---___---___---___---___"],
                outputName = ["B"],
                type = ["NAND"],
                inputName1 = ["A"],
                inputName2 = ["A"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("B --___---___---___---___---", stringOutput[0]);
        }

        [Fact]
        public void Cas3()
        {
            var input = new Input()
            {
                n = 3,
                m = 3,
                inputName = ["CLK", "IN1", "IN2"],
                inputSignal = ["_-_-_-_-_-_-_-_-_-_-_-_-_-", "___---___---___---___---__", "--__--__--__--__--__--__--"],
                outputName = ["OUT1", "OUT2", "OUT3"],
                type = ["AND", "AND", "AND"],
                inputName1 = ["CLK", "CLK", "IN1"],
                inputName2 = ["IN1", "IN2", "IN2"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("OUT1 ___-_-___-_-___-_-___-_-__", stringOutput[0]);
            Assert.Equal("OUT2 _-___-___-___-___-___-___-", stringOutput[1]);
            Assert.Equal("OUT3 ____--___-______--___-____", stringOutput[2]);
        }

        [Fact]
        public void Cas4()
        {
            var input = new Input()
            {
                n = 3,
                m = 3,
                inputName = ["CLK", "IN1", "IN2"],
                inputSignal = ["_-_-_-_-_-_-_-_-_-_-_-_-_-", "----____----____----____--", "--__--__--__--__--__--__--"],
                outputName = ["OUT1", "OUT2", "OUT3"],
                type = ["OR", "OR", "OR"],
                inputName1 = ["CLK", "CLK", "IN1"],
                inputName2 = ["IN1", "IN2", "IN2"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("OUT1 ----_-_-----_-_-----_-_---", stringOutput[0]);
            Assert.Equal("OUT2 --_---_---_---_---_---_---", stringOutput[1]);
            Assert.Equal("OUT3 ------__------__------__--", stringOutput[2]);
        }
        [Fact]
        public void Cas5()
        {
            var input = new Input()
            {
                n = 3,
                m = 3,
                inputName = ["CLK", "IN1", "IN2"],
                inputSignal = ["_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_", "__--__--__--__--__--__--__--__--_", "___---___---___---___---___---___"],
                outputName = ["OUT1", "OUT2", "OUT3"],
                type = ["XOR", "XOR", "XOR"],
                inputName1 = ["IN1", "IN2", "IN2"],
                inputName2 = ["CLK", "CLK", "IN1"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("OUT1 _--__--__--__--__--__--__--__--__", stringOutput[0]);
            Assert.Equal("OUT2 _-__-__-__-__-__-__-__-__-__-__-_", stringOutput[1]);
            Assert.Equal("OUT3 __-_----_-____-_----_-____-_----_", stringOutput[2]);
        }
        [Fact]
        public void Cas6()
        {
            var input = new Input()
            {
                n = 1,
                m = 1,
                inputName = ["IN0"],
                inputSignal = ["-_--__---___----____-_--__---___"],
                outputName = ["OUT"],
                type = ["OR"],
                inputName1 = ["IN0"],
                inputName2 = ["IN0"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("OUT -_--__---___----____-_--__---___", stringOutput[0]);

        }
        [Fact]
        public void Cas7()
        {
            var input = new Input()
            {
                n = 3,
                m = 3,
                inputName = ["CLK", "IN1", "IN2"],
                inputSignal = ["_-_-_-_-_-_-_-_-_-_-_-_-_-", "___---___---___---___---__", "--__--__--__--__--__--__--"],
                outputName = ["OUT1", "OUT2", "OUT3"],
                type = ["NAND", "NAND", "NAND"],
                inputName1 = ["CLK", "CLK", "IN1"],
                inputName2 = ["IN1", "IN2", "IN2"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("OUT1 ---_-_---_-_---_-_---_-_--", stringOutput[0]);
            Assert.Equal("OUT2 -_---_---_---_---_---_---_", stringOutput[1]);
            Assert.Equal("OUT3 ----__---_------__---_----", stringOutput[2]);
        }
        [Fact]
        public void Cas8()
        {
            var input = new Input()
            {
                n = 3,
                m = 2,
                inputName = ["IN1", "IN2", "IN3"],
                inputSignal = ["--__--__--__--__--__--__--__--__--__", "____----____----____----____----____", "--------________--------________----"],
                outputName = ["OUT1", "OUT2"],
                type = ["NOR", "NOR"],
                inputName1 = ["IN2", "IN2"],
                inputName2 = ["IN1", "IN3"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("OUT1 __--______--______--______--______--", stringOutput[0]);
            Assert.Equal("OUT2 ________----____________----________", stringOutput[1]);

        }
        [Fact]
        public void Cas9()
        {
            var input = new Input()
            {
                n = 4,
                m = 3,
                inputName = ["A", "B", "C", "D"],
                inputSignal = ["-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_", "--__--__--__--____----____----______------", "-_-__--__--__---___---___---___----____---", "-----_____-----_____-----_____-----_____--"],
                outputName = ["X", "Y", "Z"],
                type = ["NXOR", "NXOR", "NXOR"],
                inputName1 = ["A", "B", "C"],
                inputName2 = ["B", "C", "D"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("X -__--__--__--__-_--_-__-_--_-__-_-_--_-_-_", stringOutput[0]);
            Assert.Equal("Y -__-_-_-_-_-_-__--_------_--__-____-___---", stringOutput[1]);
            Assert.Equal("Z -_-____--_-__--_---_--______--_--------_--", stringOutput[2]);
        }
        [Fact]
        public void Cas10()
        {
            var input = new Input()
            {
                n = 4,
                m = 16,
                inputName = ["ZORGLUB", "MEGAMAN", "ZOLTRON", "PEW_PEW"],
                inputSignal = ["----____----____----____----____----____--",
                    "--____----____----____----____----____----",
                    "---___---___------______------______-_-_-_",
                    "-_-_-_-_------_____----____---___--__--__-"],
                outputName = ["OUTPUT1", "OUTPUT2", "OUTPUT3", "OUTPUT4", "ROGUE_1", "ROGUE_2",
                    "ROGUE_3", "ROGUE_4", "SQUAD_1", "SQUAD_2", "SQUAD_3","SQUAD_4","MIKADO1",
                    "MIKADO2","MIKADO3","MIKADO4"],
                type = ["AND", "OR", "XOR", "AND", "OR", "NAND", "NOR", "NXOR", "NAND", "OR", "NOR", "AND", "AND", "OR", "XOR", "NXOR"],
                inputName1 = ["ZORGLUB", "ZORGLUB", "ZORGLUB", "ZORGLUB", "MEGAMAN", "MEGAMAN",
                    "PEW_PEW", "PEW_PEW", "PEW_PEW", "ZOLTRON", "ZOLTRON","ZOLTRON","MEGAMAN","MEGAMAN","MEGAMAN","ZOLTRON"],
                inputName2 = ["MEGAMAN", "ZOLTRON", "PEW_PEW", "ZORGLUB", "MEGAMAN", "MEGAMAN",
                    "PEW_PEW", "MEGAMAN", "MEGAMAN", "PEW_PEW", "PEW_PEW","PEW_PEW","PEW_PEW","PEW_PEW","MEGAMAN","ZOLTRON"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.GenrationChaine(i, input));
            }

            Assert.Equal("OUTPUT1 --______--______--______--______--______--", stringOutput[0]);
            Assert.Equal("OUTPUT2 ----__--------------____------__-----_-_--", stringOutput[1]);
            Assert.Equal("OUTPUT3 _-_--_-_____--__---_---_---_--__-__-_--_-_", stringOutput[2]);
            Assert.Equal("OUTPUT4 ----____----____----____----____----____--", stringOutput[3]);
            Assert.Equal("ROGUE_1 --____----____----____----____----____----", stringOutput[4]);
            Assert.Equal("ROGUE_2 __----____----____----____----____----____", stringOutput[5]);
            Assert.Equal("ROGUE_3 _-_-_-_-______-----____----___---__--__--_", stringOutput[6]);
            Assert.Equal("ROGUE_4 -__-_--_--________-___-___-______-_--_-__-", stringOutput[7]);
            Assert.Equal("SQUAD_1 _-----_-__------------_----------_----_--_", stringOutput[8]);
            Assert.Equal("SQUAD_2 ---_-_------------_----_------___--_---_--", stringOutput[9]);
            Assert.Equal("SQUAD_3 ___-_-____________-____-______---__-___-__", stringOutput[10]);
            Assert.Equal("SQUAD_4 -_-___-_-___--_____________---________-___", stringOutput[11]);
            Assert.Equal("MIKADO1 -_____-_--____________-__________-____-__-", stringOutput[12]);
            Assert.Equal("MIKADO2 ---_-_------------_-------_--------__-----", stringOutput[13]);
            Assert.Equal("MIKADO3 __________________________________________", stringOutput[14]);
            Assert.Equal("MIKADO4 ------------------------------------------", stringOutput[15]);

        }
        [Fact]
        public void CasTest()
        {
            var input = new Input()
            {
                n = 4,
                m = 16,
                inputName = ["ZORGLUB", "MEGAMAN", "ZOLTRON", "PEW_PEW"],
                inputSignal = ["----____----____----____----____----____--",
                    "--____----____----____----____----____----",
                    "---___---___------______------______-_-_-_",
                    "-_-_-_-_------_____----____---___--__--__-"],
                outputName = ["OUTPUT1", "OUTPUT2", "OUTPUT3", "OUTPUT4", "ROGUE_1", "ROGUE_2",
                    "ROGUE_3", "ROGUE_4", "SQUAD_1", "SQUAD_2", "SQUAD_3","SQUAD_4","MIKADO1",
                    "MIKADO2","MIKADO3","MIKADO4"],
                type = ["AND", "OR", "XOR", "AND", "OR", "NAND", "NOR", "NXOR", "NAND", "OR", "NOR", "AND", "AND", "OR", "XOR", "NXOR"],
                inputName1 = ["ZORGLUB", "ZORGLUB", "ZORGLUB", "ZORGLUB", "MEGAMAN", "MEGAMAN",
                    "PEW_PEW", "PEW_PEW", "PEW_PEW", "ZOLTRON", "ZOLTRON","ZOLTRON","MEGAMAN","MEGAMAN","MEGAMAN","ZOLTRON"],
                inputName2 = ["MEGAMAN", "ZOLTRON", "PEW_PEW", "ZORGLUB", "MEGAMAN", "MEGAMAN",
                    "PEW_PEW", "MEGAMAN", "MEGAMAN", "PEW_PEW", "PEW_PEW","PEW_PEW","PEW_PEW","PEW_PEW","MEGAMAN","ZOLTRON"]
            };

            var stringOutput = new List<string>();
            for (int i = 0; i < input.m; i++)
            {
                stringOutput.Add(LogicGates.Solution2(i, input));
            }

            Assert.Equal("OUTPUT1 --______--______--______--______--______--", stringOutput[0]);
            Assert.Equal("OUTPUT2 ----__--------------____------__-----_-_--", stringOutput[1]);
            Assert.Equal("OUTPUT3 _-_--_-_____--__---_---_---_--__-__-_--_-_", stringOutput[2]);
            Assert.Equal("OUTPUT4 ----____----____----____----____----____--", stringOutput[3]);
            Assert.Equal("ROGUE_1 --____----____----____----____----____----", stringOutput[4]);
            Assert.Equal("ROGUE_2 __----____----____----____----____----____", stringOutput[5]);
            Assert.Equal("ROGUE_3 _-_-_-_-______-----____----___---__--__--_", stringOutput[6]);
            Assert.Equal("ROGUE_4 -__-_--_--________-___-___-______-_--_-__-", stringOutput[7]);
            Assert.Equal("SQUAD_1 _-----_-__------------_----------_----_--_", stringOutput[8]);
            Assert.Equal("SQUAD_2 ---_-_------------_----_------___--_---_--", stringOutput[9]);
            Assert.Equal("SQUAD_3 ___-_-____________-____-______---__-___-__", stringOutput[10]);
            Assert.Equal("SQUAD_4 -_-___-_-___--_____________---________-___", stringOutput[11]);
            Assert.Equal("MIKADO1 -_____-_--____________-__________-____-__-", stringOutput[12]);
            Assert.Equal("MIKADO2 ---_-_------------_-------_--------__-----", stringOutput[13]);
            Assert.Equal("MIKADO3 __________________________________________", stringOutput[14]);
            Assert.Equal("MIKADO4 ------------------------------------------", stringOutput[15]);
        }
    }
}