<?xml version="1.0" encoding="UTF-8"?>
<drawing version="7">
    <attr value="spartan3e" name="DeviceFamilyName">
        <trait delete="all:0" />
        <trait editname="all:0" />
        <trait edittrait="all:0" />
    </attr>
    <netlist>
        <signal name="XLXN_1" />
        <signal name="q(1)" />
        <signal name="q(2)" />
        <signal name="q(3)" />
        <signal name="q(0)" />
        <signal name="q(3:0)">
        </signal>
        <signal name="XLXN_9" />
        <signal name="XLXN_10" />
        <signal name="XLXN_11" />
        <signal name="sw" />
        <signal name="XLXN_14" />
        <signal name="clk" />
        <signal name="XLXN_16" />
        <signal name="seg(6:0)" />
        <port polarity="Input" name="sw" />
        <port polarity="Input" name="clk" />
        <port polarity="Output" name="seg(6:0)" />
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
        <blockdef name="gnd">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-64" y2="-96" x1="64" />
            <line x2="52" y1="-48" y2="-48" x1="76" />
            <line x2="60" y1="-32" y2="-32" x1="68" />
            <line x2="40" y1="-64" y2="-64" x1="88" />
            <line x2="64" y1="-64" y2="-80" x1="64" />
            <line x2="64" y1="-128" y2="-96" x1="64" />
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
        <blockdef name="hex_7seg">
            <timestamp>2014-3-25T13:20:34</timestamp>
            <rect width="256" x="64" y="-64" height="64" />
            <rect width="64" x="0" y="-44" height="24" />
            <line x2="0" y1="-32" y2="-32" x1="64" />
            <rect width="64" x="320" y="-44" height="24" />
            <line x2="384" y1="-32" y2="-32" x1="320" />
        </blockdef>
        <block symbolname="cb4ce" name="XLXI_1">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="XLXN_10" name="CE" />
            <blockpin signalname="XLXN_9" name="CLR" />
            <blockpin name="CEO" />
            <blockpin signalname="XLXN_1" name="Q0" />
            <blockpin signalname="q(1)" name="Q1" />
            <blockpin signalname="q(2)" name="Q2" />
            <blockpin signalname="q(3)" name="Q3" />
            <blockpin name="TC" />
        </block>
        <block symbolname="gnd" name="XLXI_3">
            <blockpin signalname="q(0)" name="G" />
        </block>
        <block symbolname="gnd" name="XLXI_4">
            <blockpin signalname="XLXN_9" name="G" />
        </block>
        <block symbolname="cb16ce" name="XLXI_5">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="sw" name="CE" />
            <blockpin signalname="XLXN_16" name="CLR" />
            <blockpin signalname="XLXN_10" name="CEO" />
            <blockpin name="Q(15:0)" />
            <blockpin name="TC" />
        </block>
        <block symbolname="gnd" name="XLXI_6">
            <blockpin signalname="XLXN_16" name="G" />
        </block>
        <block symbolname="hex_7seg" name="XLXI_7">
            <blockpin signalname="q(3:0)" name="d(3:0)" />
            <blockpin signalname="seg(6:0)" name="s(6:0)" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="7040" height="5440">
        <instance x="1280" y="896" name="XLXI_1" orien="R0" />
        <branch name="XLXN_1">
            <wire x2="1792" y1="448" y2="448" x1="1664" />
        </branch>
        <branch name="q(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1952" y="512" type="branch" />
            <wire x2="1952" y1="512" y2="512" x1="1664" />
            <wire x2="2000" y1="512" y2="512" x1="1952" />
        </branch>
        <branch name="q(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1952" y="576" type="branch" />
            <wire x2="1952" y1="576" y2="576" x1="1664" />
            <wire x2="2000" y1="576" y2="576" x1="1952" />
        </branch>
        <branch name="q(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1936" y="640" type="branch" />
            <wire x2="1936" y1="640" y2="640" x1="1664" />
            <wire x2="2000" y1="640" y2="640" x1="1936" />
        </branch>
        <branch name="q(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2240" y="368" type="branch" />
            <wire x2="2240" y1="368" y2="368" x1="2096" />
            <wire x2="2288" y1="368" y2="368" x1="2240" />
        </branch>
        <instance x="2032" y="496" name="XLXI_3" orien="R0" />
        <branch name="q(3:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2304" y="720" type="branch" />
            <wire x2="2304" y1="720" y2="720" x1="2016" />
            <wire x2="2528" y1="720" y2="720" x1="2304" />
        </branch>
        <branch name="XLXN_9">
            <wire x2="1280" y1="864" y2="896" x1="1280" />
        </branch>
        <instance x="1216" y="1024" name="XLXI_4" orien="R0" />
        <instance x="560" y="624" name="XLXI_5" orien="R0" />
        <branch name="XLXN_10">
            <wire x2="1104" y1="432" y2="432" x1="944" />
            <wire x2="1104" y1="432" y2="704" x1="1104" />
            <wire x2="1280" y1="704" y2="704" x1="1104" />
        </branch>
        <branch name="sw">
            <wire x2="560" y1="432" y2="432" x1="528" />
        </branch>
        <iomarker fontsize="28" x="528" y="432" name="sw" orien="R180" />
        <branch name="clk">
            <wire x2="320" y1="496" y2="496" x1="128" />
            <wire x2="560" y1="496" y2="496" x1="320" />
            <wire x2="320" y1="496" y2="768" x1="320" />
            <wire x2="1280" y1="768" y2="768" x1="320" />
        </branch>
        <branch name="XLXN_16">
            <wire x2="560" y1="592" y2="624" x1="560" />
        </branch>
        <instance x="496" y="752" name="XLXI_6" orien="R0" />
        <iomarker fontsize="28" x="128" y="496" name="clk" orien="R180" />
        <instance x="2528" y="752" name="XLXI_7" orien="R0">
        </instance>
        <branch name="seg(6:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3104" y="720" type="branch" />
            <wire x2="3104" y1="720" y2="720" x1="2912" />
            <wire x2="3216" y1="720" y2="720" x1="3104" />
        </branch>
        <iomarker fontsize="28" x="3216" y="720" name="seg(6:0)" orien="R0" />
    </sheet>
</drawing>