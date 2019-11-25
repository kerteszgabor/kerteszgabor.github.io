<?xml version="1.0" encoding="UTF-8"?>
<drawing version="7">
    <attr value="spartan3e" name="DeviceFamilyName">
        <trait delete="all:0" />
        <trait editname="all:0" />
        <trait edittrait="all:0" />
    </attr>
    <netlist>
        <signal name="ain(3:0)" />
        <signal name="ain(0)" />
        <signal name="ain(1)" />
        <signal name="ain(2)" />
        <signal name="ain(3)" />
        <signal name="bin(3:0)" />
        <signal name="bin(0)" />
        <signal name="bin(1)" />
        <signal name="bin(2)" />
        <signal name="bin(3)" />
        <signal name="XLXN_11" />
        <signal name="sel" />
        <signal name="ki(3:0)" />
        <signal name="ki(0)" />
        <signal name="XLXN_15" />
        <signal name="ki(1)" />
        <signal name="ki(2)" />
        <signal name="ki(3)" />
        <port polarity="Input" name="ain(3:0)" />
        <port polarity="Input" name="bin(3:0)" />
        <port polarity="Input" name="sel" />
        <port polarity="Output" name="ki(3:0)" />
        <blockdef name="m2_1">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="96" y1="-64" y2="-192" x1="96" />
            <line x2="96" y1="-96" y2="-64" x1="256" />
            <line x2="256" y1="-160" y2="-96" x1="256" />
            <line x2="256" y1="-192" y2="-160" x1="96" />
            <line x2="96" y1="-32" y2="-32" x1="176" />
            <line x2="176" y1="-80" y2="-32" x1="176" />
            <line x2="96" y1="-32" y2="-32" x1="0" />
            <line x2="256" y1="-128" y2="-128" x1="320" />
            <line x2="96" y1="-96" y2="-96" x1="0" />
            <line x2="96" y1="-160" y2="-160" x1="0" />
        </blockdef>
        <block symbolname="m2_1" name="XLXI_1">
            <blockpin signalname="ain(0)" name="D0" />
            <blockpin signalname="bin(0)" name="D1" />
            <blockpin signalname="sel" name="S0" />
            <blockpin signalname="ki(0)" name="O" />
        </block>
        <block symbolname="m2_1" name="XLXI_3">
            <blockpin signalname="ain(2)" name="D0" />
            <blockpin signalname="bin(2)" name="D1" />
            <blockpin signalname="sel" name="S0" />
            <blockpin signalname="ki(2)" name="O" />
        </block>
        <block symbolname="m2_1" name="XLXI_4">
            <blockpin signalname="ain(3)" name="D0" />
            <blockpin signalname="bin(3)" name="D1" />
            <blockpin signalname="sel" name="S0" />
            <blockpin signalname="ki(3)" name="O" />
        </block>
        <block symbolname="m2_1" name="XLXI_2">
            <blockpin signalname="ain(1)" name="D0" />
            <blockpin signalname="bin(1)" name="D1" />
            <blockpin signalname="sel" name="S0" />
            <blockpin signalname="ki(1)" name="O" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="1760" height="1360">
        <instance x="688" y="496" name="XLXI_1" orien="R0" />
        <instance x="688" y="960" name="XLXI_3" orien="R0" />
        <instance x="688" y="1184" name="XLXI_4" orien="R0" />
        <instance x="688" y="720" name="XLXI_2" orien="R0" />
        <branch name="ain(3:0)">
            <wire x2="288" y1="288" y2="288" x1="192" />
            <wire x2="288" y1="288" y2="336" x1="288" />
            <wire x2="288" y1="336" y2="560" x1="288" />
            <wire x2="288" y1="560" y2="800" x1="288" />
            <wire x2="288" y1="800" y2="1024" x1="288" />
        </branch>
        <iomarker fontsize="28" x="192" y="288" name="ain(3:0)" orien="R180" />
        <bustap x2="384" y1="336" y2="336" x1="288" />
        <branch name="ain(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="560" y="336" type="branch" />
            <wire x2="560" y1="336" y2="336" x1="384" />
            <wire x2="688" y1="336" y2="336" x1="560" />
        </branch>
        <bustap x2="384" y1="560" y2="560" x1="288" />
        <branch name="ain(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="560" y="560" type="branch" />
            <wire x2="560" y1="560" y2="560" x1="384" />
            <wire x2="688" y1="560" y2="560" x1="560" />
        </branch>
        <bustap x2="384" y1="800" y2="800" x1="288" />
        <branch name="ain(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="560" y="800" type="branch" />
            <wire x2="560" y1="800" y2="800" x1="384" />
            <wire x2="688" y1="800" y2="800" x1="560" />
        </branch>
        <bustap x2="384" y1="1024" y2="1024" x1="288" />
        <branch name="ain(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="560" y="1024" type="branch" />
            <wire x2="560" y1="1024" y2="1024" x1="384" />
            <wire x2="688" y1="1024" y2="1024" x1="560" />
        </branch>
        <branch name="bin(3:0)">
            <wire x2="400" y1="160" y2="160" x1="192" />
            <wire x2="400" y1="160" y2="400" x1="400" />
            <wire x2="400" y1="400" y2="624" x1="400" />
            <wire x2="400" y1="624" y2="864" x1="400" />
            <wire x2="400" y1="864" y2="1088" x1="400" />
        </branch>
        <iomarker fontsize="28" x="192" y="160" name="bin(3:0)" orien="R180" />
        <bustap x2="496" y1="400" y2="400" x1="400" />
        <branch name="bin(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="560" y="400" type="branch" />
            <wire x2="560" y1="400" y2="400" x1="496" />
            <wire x2="688" y1="400" y2="400" x1="560" />
        </branch>
        <bustap x2="496" y1="624" y2="624" x1="400" />
        <branch name="bin(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="560" y="624" type="branch" />
            <wire x2="560" y1="624" y2="624" x1="496" />
            <wire x2="688" y1="624" y2="624" x1="560" />
        </branch>
        <bustap x2="496" y1="864" y2="864" x1="400" />
        <branch name="bin(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="560" y="864" type="branch" />
            <wire x2="560" y1="864" y2="864" x1="496" />
            <wire x2="688" y1="864" y2="864" x1="560" />
        </branch>
        <bustap x2="496" y1="1088" y2="1088" x1="400" />
        <branch name="bin(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="560" y="1088" type="branch" />
            <wire x2="560" y1="1088" y2="1088" x1="496" />
            <wire x2="688" y1="1088" y2="1088" x1="560" />
        </branch>
        <branch name="sel">
            <wire x2="640" y1="1152" y2="1152" x1="144" />
            <wire x2="688" y1="1152" y2="1152" x1="640" />
            <wire x2="688" y1="464" y2="464" x1="640" />
            <wire x2="640" y1="464" y2="688" x1="640" />
            <wire x2="688" y1="688" y2="688" x1="640" />
            <wire x2="640" y1="688" y2="928" x1="640" />
            <wire x2="640" y1="928" y2="1152" x1="640" />
            <wire x2="688" y1="928" y2="928" x1="640" />
        </branch>
        <iomarker fontsize="28" x="144" y="1152" name="sel" orien="R180" />
        <iomarker fontsize="28" x="1584" y="160" name="ki(3:0)" orien="R0" />
        <bustap x2="1152" y1="368" y2="368" x1="1248" />
        <branch name="ki(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="1088" y="368" type="branch" />
            <wire x2="1088" y1="368" y2="368" x1="1008" />
            <wire x2="1152" y1="368" y2="368" x1="1088" />
        </branch>
        <branch name="ki(3:0)">
            <wire x2="1584" y1="160" y2="160" x1="1248" />
            <wire x2="1248" y1="160" y2="368" x1="1248" />
            <wire x2="1248" y1="368" y2="592" x1="1248" />
            <wire x2="1248" y1="592" y2="832" x1="1248" />
            <wire x2="1248" y1="832" y2="1056" x1="1248" />
        </branch>
        <bustap x2="1152" y1="592" y2="592" x1="1248" />
        <branch name="ki(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="1088" y="592" type="branch" />
            <wire x2="1088" y1="592" y2="592" x1="1008" />
            <wire x2="1152" y1="592" y2="592" x1="1088" />
        </branch>
        <bustap x2="1152" y1="832" y2="832" x1="1248" />
        <branch name="ki(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="1088" y="832" type="branch" />
            <wire x2="1088" y1="832" y2="832" x1="1008" />
            <wire x2="1152" y1="832" y2="832" x1="1088" />
        </branch>
        <bustap x2="1152" y1="1056" y2="1056" x1="1248" />
        <branch name="ki(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:32;fontname:Arial" attrname="Name" x="1088" y="1056" type="branch" />
            <wire x2="1088" y1="1056" y2="1056" x1="1008" />
            <wire x2="1152" y1="1056" y2="1056" x1="1088" />
        </branch>
    </sheet>
</drawing>