<?xml version="1.0" encoding="UTF-8"?>
<drawing version="7">
    <attr value="spartan3e" name="DeviceFamilyName">
        <trait delete="all:0" />
        <trait editname="all:0" />
        <trait edittrait="all:0" />
    </attr>
    <netlist>
        <signal name="XLXN_12" />
        <signal name="q(3:0)">
        </signal>
        <signal name="q(0)" />
        <signal name="q(1)" />
        <signal name="q(2)" />
        <signal name="q(3)" />
        <signal name="clk" />
        <signal name="XLXN_22" />
        <signal name="XLXN_21" />
        <signal name="XLXN_25" />
        <signal name="seg(6:0)" />
        <signal name="an(0)" />
        <signal name="an(1)" />
        <signal name="an(2)" />
        <signal name="an(3)" />
        <signal name="XLXN_31" />
        <signal name="sw" />
        <signal name="bt" />
        <port polarity="Input" name="clk" />
        <port polarity="Output" name="seg(6:0)" />
        <port polarity="Output" name="an(0)" />
        <port polarity="Output" name="an(1)" />
        <port polarity="Output" name="an(2)" />
        <port polarity="Output" name="an(3)" />
        <port polarity="Input" name="sw" />
        <port polarity="Input" name="bt" />
        <blockdef name="cb4ce">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <rect width="256" x="64" y="-512" height="448" />
            <line x2="64" y1="-32" y2="-32" x1="0" />
            <line x2="64" y1="-128" y2="-128" x1="0" />
            <line x2="320" y1="-256" y2="-256" x1="384" />
            <line x2="320" y1="-320" y2="-320" x1="384" />
            <line x2="320" y1="-384" y2="-384" x1="384" />
            <line x2="320" y1="-448" y2="-448" x1="384" />
            <line x2="64" y1="-128" y2="-144" x1="80" />
            <line x2="80" y1="-112" y2="-128" x1="64" />
            <line x2="320" y1="-128" y2="-128" x1="384" />
            <line x2="64" y1="-32" y2="-32" x1="192" />
            <line x2="192" y1="-64" y2="-32" x1="192" />
            <line x2="64" y1="-192" y2="-192" x1="0" />
            <line x2="320" y1="-192" y2="-192" x1="384" />
        </blockdef>
        <blockdef name="and4b2">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="40" y1="-64" y2="-64" x1="0" />
            <circle r="12" cx="52" cy="-64" />
            <line x2="40" y1="-128" y2="-128" x1="0" />
            <circle r="12" cx="52" cy="-128" />
            <line x2="64" y1="-192" y2="-192" x1="0" />
            <line x2="64" y1="-256" y2="-256" x1="0" />
            <line x2="192" y1="-160" y2="-160" x1="256" />
            <line x2="144" y1="-208" y2="-208" x1="64" />
            <arc ex="144" ey="-208" sx="144" sy="-112" r="48" cx="144" cy="-160" />
            <line x2="64" y1="-64" y2="-256" x1="64" />
            <line x2="64" y1="-112" y2="-112" x1="144" />
        </blockdef>
        <blockdef name="cb16ce">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="320" y1="-192" y2="-192" x1="384" />
            <rect width="64" x="320" y="-268" height="24" />
            <line x2="320" y1="-256" y2="-256" x1="384" />
            <line x2="64" y1="-192" y2="-192" x1="0" />
            <line x2="64" y1="-32" y2="-32" x1="192" />
            <line x2="192" y1="-64" y2="-32" x1="192" />
            <line x2="64" y1="-128" y2="-144" x1="80" />
            <line x2="80" y1="-112" y2="-128" x1="64" />
            <line x2="64" y1="-128" y2="-128" x1="0" />
            <line x2="64" y1="-32" y2="-32" x1="0" />
            <line x2="320" y1="-128" y2="-128" x1="384" />
            <rect width="256" x="64" y="-320" height="256" />
        </blockdef>
        <blockdef name="gnd">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-64" y2="-96" x1="64" />
            <line x2="52" y1="-48" y2="-48" x1="76" />
            <line x2="60" y1="-32" y2="-32" x1="68" />
            <line x2="40" y1="-64" y2="-64" x1="88" />
            <line x2="64" y1="-64" y2="-80" x1="64" />
            <line x2="64" y1="-128" y2="-96" x1="64" />
        </blockdef>
        <blockdef name="hex_7seg">
            <timestamp>2014-3-25T13:20:34</timestamp>
            <rect width="256" x="64" y="-64" height="64" />
            <rect width="64" x="0" y="-44" height="24" />
            <line x2="0" y1="-32" y2="-32" x1="64" />
            <rect width="64" x="320" y="-44" height="24" />
            <line x2="384" y1="-32" y2="-32" x1="320" />
        </blockdef>
        <blockdef name="vcc">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-32" y2="-64" x1="64" />
            <line x2="64" y1="0" y2="-32" x1="64" />
            <line x2="32" y1="-64" y2="-64" x1="96" />
        </blockdef>
        <blockdef name="or2">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-64" y2="-64" x1="0" />
            <line x2="64" y1="-128" y2="-128" x1="0" />
            <line x2="192" y1="-96" y2="-96" x1="256" />
            <arc ex="192" ey="-96" sx="112" sy="-48" r="88" cx="116" cy="-136" />
            <arc ex="48" ey="-144" sx="48" sy="-48" r="56" cx="16" cy="-96" />
            <line x2="48" y1="-144" y2="-144" x1="112" />
            <arc ex="112" ey="-144" sx="192" sy="-96" r="88" cx="116" cy="-56" />
            <line x2="48" y1="-48" y2="-48" x1="112" />
        </blockdef>
        <block symbolname="cb4ce" name="XLXI_1">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="XLXN_21" name="CE" />
            <blockpin signalname="XLXN_12" name="CLR" />
            <blockpin name="CEO" />
            <blockpin signalname="q(0)" name="Q0" />
            <blockpin signalname="q(1)" name="Q1" />
            <blockpin signalname="q(2)" name="Q2" />
            <blockpin signalname="q(3)" name="Q3" />
            <blockpin name="TC" />
        </block>
        <block symbolname="and4b2" name="XLXI_3">
            <blockpin signalname="q(2)" name="I0" />
            <blockpin signalname="q(0)" name="I1" />
            <blockpin signalname="q(1)" name="I2" />
            <blockpin signalname="q(3)" name="I3" />
            <blockpin signalname="XLXN_12" name="O" />
        </block>
        <block symbolname="cb16ce" name="XLXI_4">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="XLXN_31" name="CE" />
            <blockpin signalname="XLXN_25" name="CLR" />
            <blockpin signalname="XLXN_21" name="CEO" />
            <blockpin name="Q(15:0)" />
            <blockpin name="TC" />
        </block>
        <block symbolname="gnd" name="XLXI_6">
            <blockpin signalname="XLXN_25" name="G" />
        </block>
        <block symbolname="hex_7seg" name="XLXI_10">
            <blockpin signalname="q(3:0)" name="d(3:0)" />
            <blockpin signalname="seg(6:0)" name="s(6:0)" />
        </block>
        <block symbolname="vcc" name="XLXI_11">
            <blockpin signalname="an(0)" name="P" />
        </block>
        <block symbolname="vcc" name="XLXI_12">
            <blockpin signalname="an(1)" name="P" />
        </block>
        <block symbolname="vcc" name="XLXI_13">
            <blockpin signalname="an(2)" name="P" />
        </block>
        <block symbolname="gnd" name="XLXI_14">
            <blockpin signalname="an(3)" name="G" />
        </block>
        <block symbolname="or2" name="XLXI_15">
            <blockpin signalname="sw" name="I0" />
            <blockpin signalname="bt" name="I1" />
            <blockpin signalname="XLXN_31" name="O" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="7040" height="5440">
        <instance x="1872" y="1008" name="XLXI_1" orien="R0" />
        <branch name="q(0)">
            <attrtext style="alignment:SOFT-LEFT;fontsize:28;fontname:Arial" attrname="Name" x="2560" y="560" type="branch" />
            <wire x2="2560" y1="560" y2="560" x1="2256" />
        </branch>
        <branch name="q(1)">
            <attrtext style="alignment:SOFT-LEFT;fontsize:28;fontname:Arial" attrname="Name" x="2560" y="624" type="branch" />
            <wire x2="2560" y1="624" y2="624" x1="2256" />
        </branch>
        <branch name="q(2)">
            <attrtext style="alignment:SOFT-LEFT;fontsize:28;fontname:Arial" attrname="Name" x="2560" y="688" type="branch" />
            <wire x2="2560" y1="688" y2="688" x1="2256" />
        </branch>
        <branch name="q(3)">
            <attrtext style="alignment:SOFT-LEFT;fontsize:28;fontname:Arial" attrname="Name" x="2560" y="752" type="branch" />
            <wire x2="2560" y1="752" y2="752" x1="2256" />
        </branch>
        <instance x="1936" y="1360" name="XLXI_3" orien="R0" />
        <branch name="q(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1920" y="1104" type="branch" />
            <wire x2="1920" y1="1104" y2="1104" x1="1888" />
            <wire x2="1936" y1="1104" y2="1104" x1="1920" />
        </branch>
        <branch name="q(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1920" y="1168" type="branch" />
            <wire x2="1920" y1="1168" y2="1168" x1="1888" />
            <wire x2="1936" y1="1168" y2="1168" x1="1920" />
        </branch>
        <branch name="q(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1920" y="1232" type="branch" />
            <wire x2="1920" y1="1232" y2="1232" x1="1872" />
            <wire x2="1936" y1="1232" y2="1232" x1="1920" />
        </branch>
        <branch name="q(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1920" y="1296" type="branch" />
            <wire x2="1920" y1="1296" y2="1296" x1="1872" />
            <wire x2="1936" y1="1296" y2="1296" x1="1920" />
        </branch>
        <branch name="XLXN_12">
            <wire x2="1872" y1="976" y2="1056" x1="1872" />
            <wire x2="2256" y1="1056" y2="1056" x1="1872" />
            <wire x2="2256" y1="1056" y2="1200" x1="2256" />
            <wire x2="2256" y1="1200" y2="1200" x1="2192" />
        </branch>
        <branch name="q(3:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2656" y="976" type="branch" />
            <wire x2="2528" y1="768" y2="976" x1="2528" />
            <wire x2="2656" y1="976" y2="976" x1="2528" />
            <wire x2="3088" y1="976" y2="976" x1="2656" />
            <wire x2="3008" y1="768" y2="768" x1="2528" />
        </branch>
        <instance x="272" y="1072" name="XLXI_4" orien="R0" />
        <branch name="clk">
            <wire x2="272" y1="944" y2="944" x1="96" />
            <wire x2="96" y1="944" y2="1184" x1="96" />
            <wire x2="96" y1="1184" y2="1280" x1="96" />
            <wire x2="672" y1="1184" y2="1184" x1="96" />
            <wire x2="1264" y1="1184" y2="1184" x1="672" />
            <wire x2="672" y1="656" y2="1184" x1="672" />
            <wire x2="1104" y1="656" y2="656" x1="672" />
            <wire x2="1264" y1="880" y2="1184" x1="1264" />
            <wire x2="1872" y1="880" y2="880" x1="1264" />
        </branch>
        <iomarker fontsize="28" x="96" y="1280" name="clk" orien="R90" />
        <branch name="XLXN_21">
            <wire x2="880" y1="880" y2="880" x1="656" />
            <wire x2="880" y1="592" y2="880" x1="880" />
            <wire x2="1104" y1="592" y2="592" x1="880" />
            <wire x2="1488" y1="592" y2="592" x1="1104" />
            <wire x2="1680" y1="592" y2="592" x1="1488" />
            <wire x2="1680" y1="592" y2="816" x1="1680" />
            <wire x2="1872" y1="816" y2="816" x1="1680" />
        </branch>
        <branch name="XLXN_25">
            <wire x2="272" y1="1040" y2="1072" x1="272" />
        </branch>
        <instance x="208" y="1200" name="XLXI_6" orien="R0" />
        <instance x="3088" y="1008" name="XLXI_10" orien="R0">
        </instance>
        <branch name="seg(6:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3696" y="976" type="branch" />
            <wire x2="3696" y1="976" y2="976" x1="3472" />
            <wire x2="3744" y1="976" y2="976" x1="3696" />
        </branch>
        <iomarker fontsize="28" x="3744" y="976" name="seg(6:0)" orien="R0" />
        <branch name="an(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3328" y="1456" type="branch" />
            <wire x2="3328" y1="1456" y2="1456" x1="2560" />
            <wire x2="3392" y1="1456" y2="1456" x1="3328" />
        </branch>
        <branch name="an(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3312" y="1600" type="branch" />
            <wire x2="3312" y1="1600" y2="1600" x1="2544" />
            <wire x2="3376" y1="1600" y2="1600" x1="3312" />
        </branch>
        <branch name="an(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3296" y="1664" type="branch" />
            <wire x2="3296" y1="1664" y2="1664" x1="2528" />
            <wire x2="3360" y1="1664" y2="1664" x1="3296" />
        </branch>
        <branch name="an(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3296" y="1728" type="branch" />
            <wire x2="3296" y1="1728" y2="1728" x1="2496" />
            <wire x2="3360" y1="1728" y2="1728" x1="3296" />
        </branch>
        <iomarker fontsize="28" x="3392" y="1456" name="an(0)" orien="R0" />
        <iomarker fontsize="28" x="3376" y="1600" name="an(1)" orien="R0" />
        <iomarker fontsize="28" x="3360" y="1664" name="an(2)" orien="R0" />
        <iomarker fontsize="28" x="3360" y="1728" name="an(3)" orien="R0" />
        <instance x="2496" y="1456" name="XLXI_11" orien="R0" />
        <instance x="2480" y="1600" name="XLXI_12" orien="R0" />
        <instance x="2464" y="1664" name="XLXI_13" orien="R0" />
        <instance x="2432" y="1856" name="XLXI_14" orien="R0" />
        <branch name="XLXN_31">
            <wire x2="272" y1="592" y2="592" x1="256" />
            <wire x2="256" y1="592" y2="880" x1="256" />
            <wire x2="272" y1="880" y2="880" x1="256" />
        </branch>
        <instance x="176" y="336" name="XLXI_15" orien="R90" />
        <branch name="sw">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="240" y="288" type="branch" />
            <wire x2="240" y1="256" y2="288" x1="240" />
            <wire x2="240" y1="288" y2="336" x1="240" />
        </branch>
        <branch name="bt">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="304" y="288" type="branch" />
            <wire x2="304" y1="256" y2="288" x1="304" />
            <wire x2="304" y1="288" y2="336" x1="304" />
        </branch>
        <iomarker fontsize="28" x="240" y="256" name="sw" orien="R270" />
        <iomarker fontsize="28" x="304" y="256" name="bt" orien="R270" />
    </sheet>
</drawing>