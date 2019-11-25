<?xml version="1.0" encoding="UTF-8"?>
<drawing version="7">
    <attr value="spartan3e" name="DeviceFamilyName">
        <trait delete="all:0" />
        <trait editname="all:0" />
        <trait edittrait="all:0" />
    </attr>
    <netlist>
        <signal name="q(7:0)" />
        <signal name="clr" />
        <signal name="clk" />
        <signal name="q(0)" />
        <signal name="q(1)" />
        <signal name="q(2)" />
        <signal name="q(3)" />
        <signal name="XLXN_13" />
        <signal name="XLXN_14" />
        <signal name="enable" />
        <signal name="q(4)" />
        <signal name="q(5)" />
        <signal name="q(6)" />
        <signal name="q(7)" />
        <signal name="led(7:0)" />
        <signal name="XLXN_33" />
        <port polarity="Input" name="clr" />
        <port polarity="Input" name="clk" />
        <port polarity="Input" name="enable" />
        <port polarity="Output" name="led(7:0)" />
        <blockdef name="ftce">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-32" y2="-32" x1="192" />
            <line x2="192" y1="-64" y2="-32" x1="192" />
            <line x2="64" y1="-128" y2="-144" x1="80" />
            <line x2="80" y1="-112" y2="-128" x1="64" />
            <line x2="320" y1="-256" y2="-256" x1="384" />
            <line x2="64" y1="-256" y2="-256" x1="0" />
            <line x2="64" y1="-32" y2="-32" x1="0" />
            <line x2="64" y1="-192" y2="-192" x1="0" />
            <line x2="64" y1="-128" y2="-128" x1="0" />
            <rect width="256" x="64" y="-320" height="256" />
        </blockdef>
        <blockdef name="and3">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-64" y2="-64" x1="0" />
            <line x2="64" y1="-128" y2="-128" x1="0" />
            <line x2="64" y1="-192" y2="-192" x1="0" />
            <line x2="192" y1="-128" y2="-128" x1="256" />
            <line x2="144" y1="-176" y2="-176" x1="64" />
            <line x2="64" y1="-80" y2="-80" x1="144" />
            <arc ex="144" ey="-176" sx="144" sy="-80" r="48" cx="144" cy="-128" />
            <line x2="64" y1="-64" y2="-192" x1="64" />
        </blockdef>
        <blockdef name="and2">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-64" y2="-64" x1="0" />
            <line x2="64" y1="-128" y2="-128" x1="0" />
            <line x2="192" y1="-96" y2="-96" x1="256" />
            <arc ex="144" ey="-144" sx="144" sy="-48" r="48" cx="144" cy="-96" />
            <line x2="64" y1="-48" y2="-48" x1="144" />
            <line x2="144" y1="-144" y2="-144" x1="64" />
            <line x2="64" y1="-48" y2="-144" x1="64" />
        </blockdef>
        <blockdef name="pulldown">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-160" y2="-128" x1="64" />
            <line x2="60" y1="0" y2="0" x1="68" />
            <line x2="52" y1="-16" y2="-16" x1="76" />
            <line x2="40" y1="-32" y2="-32" x1="88" />
            <line x2="64" y1="-108" y2="-128" x1="64" />
            <line x2="64" y1="-104" y2="-108" x1="80" />
            <line x2="80" y1="-88" y2="-104" x1="48" />
            <line x2="48" y1="-72" y2="-88" x1="80" />
            <line x2="80" y1="-56" y2="-72" x1="48" />
            <line x2="48" y1="-48" y2="-56" x1="64" />
            <line x2="64" y1="-32" y2="-48" x1="64" />
        </blockdef>
        <blockdef name="obuf8">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-32" y2="-32" x1="0" />
            <line x2="64" y1="0" y2="-64" x1="64" />
            <line x2="64" y1="-32" y2="0" x1="128" />
            <line x2="128" y1="-64" y2="-32" x1="64" />
            <line x2="128" y1="-32" y2="-32" x1="224" />
            <rect width="64" x="0" y="-44" height="24" />
            <rect width="96" x="128" y="-44" height="24" />
        </blockdef>
        <blockdef name="pullup">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-108" y2="-128" x1="64" />
            <line x2="64" y1="-104" y2="-108" x1="80" />
            <line x2="80" y1="-88" y2="-104" x1="48" />
            <line x2="48" y1="-72" y2="-88" x1="80" />
            <line x2="80" y1="-56" y2="-72" x1="48" />
            <line x2="48" y1="-48" y2="-56" x1="64" />
            <line x2="64" y1="-32" y2="-48" x1="64" />
            <line x2="64" y1="-56" y2="-48" x1="48" />
            <line x2="48" y1="-72" y2="-56" x1="80" />
            <line x2="80" y1="-88" y2="-72" x1="48" />
            <line x2="48" y1="-104" y2="-88" x1="80" />
            <line x2="80" y1="-108" y2="-104" x1="64" />
            <line x2="64" y1="0" y2="-32" x1="64" />
            <line x2="32" y1="-128" y2="-128" x1="96" />
        </blockdef>
        <block symbolname="ftce" name="XLXI_1">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="enable" name="CE" />
            <blockpin signalname="clr" name="CLR" />
            <blockpin signalname="XLXN_13" name="T" />
            <blockpin signalname="q(3)" name="Q" />
        </block>
        <block symbolname="ftce" name="XLXI_2">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="enable" name="CE" />
            <blockpin signalname="clr" name="CLR" />
            <blockpin signalname="XLXN_14" name="T" />
            <blockpin signalname="q(2)" name="Q" />
        </block>
        <block symbolname="ftce" name="XLXI_3">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="enable" name="CE" />
            <blockpin signalname="clr" name="CLR" />
            <blockpin signalname="q(0)" name="T" />
            <blockpin signalname="q(1)" name="Q" />
        </block>
        <block symbolname="ftce" name="XLXI_4">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="enable" name="CE" />
            <blockpin signalname="clr" name="CLR" />
            <blockpin signalname="XLXN_33" name="T" />
            <blockpin signalname="q(0)" name="Q" />
        </block>
        <block symbolname="and3" name="XLXI_5">
            <blockpin signalname="q(2)" name="I0" />
            <blockpin signalname="q(0)" name="I1" />
            <blockpin signalname="q(1)" name="I2" />
            <blockpin signalname="XLXN_13" name="O" />
        </block>
        <block symbolname="and2" name="XLXI_6">
            <blockpin signalname="q(1)" name="I0" />
            <blockpin signalname="q(0)" name="I1" />
            <blockpin signalname="XLXN_14" name="O" />
        </block>
        <block symbolname="pulldown" name="XLXI_7">
            <blockpin signalname="q(7)" name="O" />
        </block>
        <block symbolname="pulldown" name="XLXI_8">
            <blockpin signalname="q(6)" name="O" />
        </block>
        <block symbolname="pulldown" name="XLXI_9">
            <blockpin signalname="q(5)" name="O" />
        </block>
        <block symbolname="pulldown" name="XLXI_10">
            <blockpin signalname="q(4)" name="O" />
        </block>
        <block symbolname="obuf8" name="XLXI_11">
            <blockpin signalname="q(7:0)" name="I(7:0)" />
            <blockpin signalname="led(7:0)" name="O(7:0)" />
        </block>
        <block symbolname="pullup" name="XLXI_12">
            <blockpin signalname="XLXN_33" name="O" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="3520" height="2720">
        <instance x="768" y="640" name="XLXI_1" orien="R0" />
        <instance x="768" y="1056" name="XLXI_2" orien="R0" />
        <instance x="768" y="1424" name="XLXI_3" orien="R0" />
        <instance x="768" y="1760" name="XLXI_4" orien="R0" />
        <bustap x2="1376" y1="800" y2="800" x1="1472" />
        <bustap x2="1376" y1="400" y2="400" x1="1472" />
        <bustap x2="1376" y1="1168" y2="1168" x1="1472" />
        <bustap x2="1376" y1="1520" y2="1520" x1="1472" />
        <instance x="80" y="512" name="XLXI_5" orien="R0" />
        <instance x="80" y="896" name="XLXI_6" orien="R0" />
        <iomarker fontsize="28" x="128" y="1632" name="clk" orien="R180" />
        <iomarker fontsize="28" x="128" y="1744" name="clr" orien="R180" />
        <bustap x2="1568" y1="464" y2="464" x1="1472" />
        <bustap x2="1568" y1="528" y2="528" x1="1472" />
        <bustap x2="1568" y1="592" y2="592" x1="1472" />
        <bustap x2="1568" y1="656" y2="656" x1="1472" />
        <instance x="1696" y="816" name="XLXI_7" orien="R0" />
        <instance x="1872" y="832" name="XLXI_8" orien="R0" />
        <instance x="1952" y="832" name="XLXI_9" orien="R0" />
        <instance x="2080" y="816" name="XLXI_10" orien="R0" />
        <instance x="1808" y="1440" name="XLXI_11" orien="R0" />
        <iomarker fontsize="28" x="2272" y="1408" name="led(7:0)" orien="R0" />
        <instance x="224" y="1504" name="XLXI_12" orien="R0" />
        <iomarker fontsize="28" x="240" y="1104" name="enable" orien="R180" />
        <branch name="q(7:0)">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1472" y="384" type="branch" />
            <wire x2="1472" y1="352" y2="352" x1="1456" />
            <wire x2="1472" y1="352" y2="384" x1="1472" />
            <wire x2="1472" y1="384" y2="400" x1="1472" />
            <wire x2="1472" y1="400" y2="464" x1="1472" />
            <wire x2="1472" y1="464" y2="480" x1="1472" />
            <wire x2="1472" y1="480" y2="528" x1="1472" />
            <wire x2="1472" y1="528" y2="592" x1="1472" />
            <wire x2="1472" y1="592" y2="656" x1="1472" />
            <wire x2="1472" y1="656" y2="800" x1="1472" />
            <wire x2="1472" y1="800" y2="1168" x1="1472" />
            <wire x2="1472" y1="1168" y2="1408" x1="1472" />
            <wire x2="1808" y1="1408" y2="1408" x1="1472" />
            <wire x2="1472" y1="1408" y2="1520" x1="1472" />
            <wire x2="1472" y1="1520" y2="1552" x1="1472" />
        </branch>
        <branch name="clr">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="176" y="1744" type="branch" />
            <wire x2="176" y1="1744" y2="1744" x1="128" />
            <wire x2="560" y1="1744" y2="1744" x1="176" />
            <wire x2="768" y1="1744" y2="1744" x1="560" />
            <wire x2="768" y1="608" y2="608" x1="560" />
            <wire x2="560" y1="608" y2="1024" x1="560" />
            <wire x2="768" y1="1024" y2="1024" x1="560" />
            <wire x2="560" y1="1024" y2="1392" x1="560" />
            <wire x2="768" y1="1392" y2="1392" x1="560" />
            <wire x2="560" y1="1392" y2="1744" x1="560" />
            <wire x2="768" y1="1728" y2="1744" x1="768" />
        </branch>
        <branch name="clk">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="144" y="1632" type="branch" />
            <wire x2="144" y1="1632" y2="1632" x1="128" />
            <wire x2="448" y1="1632" y2="1632" x1="144" />
            <wire x2="768" y1="1632" y2="1632" x1="448" />
            <wire x2="768" y1="512" y2="512" x1="448" />
            <wire x2="448" y1="512" y2="928" x1="448" />
            <wire x2="768" y1="928" y2="928" x1="448" />
            <wire x2="448" y1="928" y2="1296" x1="448" />
            <wire x2="448" y1="1296" y2="1632" x1="448" />
            <wire x2="768" y1="1296" y2="1296" x1="448" />
        </branch>
        <branch name="q(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1280" y="1520" type="branch" />
            <wire x2="1264" y1="1504" y2="1504" x1="1152" />
            <wire x2="1264" y1="1504" y2="1520" x1="1264" />
            <wire x2="1280" y1="1520" y2="1520" x1="1264" />
            <wire x2="1376" y1="1520" y2="1520" x1="1280" />
        </branch>
        <branch name="q(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1296" y="1168" type="branch" />
            <wire x2="1296" y1="1168" y2="1168" x1="1152" />
            <wire x2="1376" y1="1168" y2="1168" x1="1296" />
        </branch>
        <branch name="q(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1280" y="800" type="branch" />
            <wire x2="1280" y1="800" y2="800" x1="1152" />
            <wire x2="1376" y1="800" y2="800" x1="1280" />
        </branch>
        <branch name="q(3)">
            <attrtext style="alignment:SOFT-TCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1264" y="400" type="branch" />
            <wire x2="1264" y1="384" y2="384" x1="1152" />
            <wire x2="1264" y1="384" y2="400" x1="1264" />
            <wire x2="1376" y1="400" y2="400" x1="1264" />
        </branch>
        <branch name="XLXN_13">
            <wire x2="336" y1="384" y2="384" x1="320" />
            <wire x2="768" y1="384" y2="384" x1="336" />
        </branch>
        <branch name="XLXN_14">
            <wire x2="768" y1="800" y2="800" x1="336" />
        </branch>
        <branch name="q(0)">
            <attrtext style="alignment:SOFT-VRIGHT;fontsize:28;fontname:Arial" attrname="Name" x="320" y="1184" type="branch" />
            <wire x2="768" y1="1168" y2="1168" x1="320" />
            <wire x2="320" y1="1168" y2="1184" x1="320" />
        </branch>
        <branch name="enable">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="304" y="1104" type="branch" />
            <wire x2="304" y1="1104" y2="1104" x1="240" />
            <wire x2="752" y1="1104" y2="1104" x1="304" />
            <wire x2="752" y1="1104" y2="1232" x1="752" />
            <wire x2="752" y1="1232" y2="1568" x1="752" />
            <wire x2="768" y1="1568" y2="1568" x1="752" />
            <wire x2="768" y1="1232" y2="1232" x1="752" />
            <wire x2="768" y1="448" y2="448" x1="752" />
            <wire x2="752" y1="448" y2="864" x1="752" />
            <wire x2="768" y1="864" y2="864" x1="752" />
            <wire x2="752" y1="864" y2="1104" x1="752" />
        </branch>
        <branch name="q(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="64" y="384" type="branch" />
            <wire x2="64" y1="384" y2="384" x1="48" />
            <wire x2="80" y1="384" y2="384" x1="64" />
        </branch>
        <branch name="q(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="64" y="448" type="branch" />
            <wire x2="64" y1="448" y2="448" x1="48" />
            <wire x2="80" y1="448" y2="448" x1="64" />
        </branch>
        <branch name="q(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="64" y="768" type="branch" />
            <wire x2="64" y1="768" y2="768" x1="32" />
            <wire x2="80" y1="768" y2="768" x1="64" />
        </branch>
        <branch name="q(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="64" y="832" type="branch" />
            <wire x2="64" y1="832" y2="832" x1="32" />
            <wire x2="80" y1="832" y2="832" x1="64" />
        </branch>
        <branch name="q(4)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1600" y="464" type="branch" />
            <wire x2="1600" y1="464" y2="464" x1="1568" />
            <wire x2="2144" y1="464" y2="464" x1="1600" />
            <wire x2="2144" y1="464" y2="656" x1="2144" />
        </branch>
        <branch name="q(5)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1600" y="528" type="branch" />
            <wire x2="1600" y1="528" y2="528" x1="1568" />
            <wire x2="2016" y1="528" y2="528" x1="1600" />
            <wire x2="2016" y1="528" y2="672" x1="2016" />
        </branch>
        <branch name="q(6)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1600" y="592" type="branch" />
            <wire x2="1600" y1="592" y2="592" x1="1568" />
            <wire x2="1936" y1="592" y2="592" x1="1600" />
            <wire x2="1936" y1="592" y2="672" x1="1936" />
            <wire x2="1936" y1="672" y2="688" x1="1936" />
        </branch>
        <branch name="q(7)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1600" y="656" type="branch" />
            <wire x2="1600" y1="656" y2="656" x1="1568" />
            <wire x2="1760" y1="656" y2="656" x1="1600" />
        </branch>
        <branch name="led(7:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2224" y="1408" type="branch" />
            <wire x2="2224" y1="1408" y2="1408" x1="2032" />
            <wire x2="2272" y1="1408" y2="1408" x1="2224" />
        </branch>
        <branch name="XLXN_33">
            <wire x2="768" y1="1504" y2="1504" x1="288" />
        </branch>
        <branch name="q(1)">
            <attrtext style="alignment:SOFT-RIGHT;fontsize:28;fontname:Arial" attrname="Name" x="48" y="320" type="branch" />
            <wire x2="64" y1="320" y2="320" x1="48" />
            <wire x2="80" y1="320" y2="320" x1="64" />
        </branch>
    </sheet>
</drawing>