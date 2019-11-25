<?xml version="1.0" encoding="UTF-8"?>
<drawing version="7">
    <attr value="spartan3e" name="DeviceFamilyName">
        <trait delete="all:0" />
        <trait editname="all:0" />
        <trait edittrait="all:0" />
    </attr>
    <netlist>
        <signal name="a" />
        <signal name="b" />
        <signal name="c" />
        <signal name="XLXN_4" />
        <signal name="XLXN_5" />
        <signal name="XLXN_6" />
        <signal name="XLXN_7" />
        <signal name="XLXN_8" />
        <signal name="XLXN_9" />
        <signal name="XLXN_10" />
        <signal name="XLXN_11" />
        <signal name="XLXN_12" />
        <signal name="XLXN_13" />
        <signal name="XLXN_14" />
        <signal name="XLXN_15" />
        <signal name="dd(3:0)" />
        <signal name="dd(0)" />
        <signal name="dd(3)" />
        <signal name="dd(2)" />
        <signal name="dd(1)" />
        <signal name="seg(6:0)" />
        <signal name="led(0)" />
        <signal name="led(1)" />
        <signal name="led(2)" />
        <signal name="an0" />
        <port polarity="Input" name="a" />
        <port polarity="Input" name="b" />
        <port polarity="Input" name="c" />
        <port polarity="Output" name="seg(6:0)" />
        <port polarity="Output" name="led(0)" />
        <port polarity="Output" name="led(1)" />
        <port polarity="Output" name="led(2)" />
        <port polarity="Output" name="an0" />
        <blockdef name="ibuf">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="0" y2="-64" x1="64" />
            <line x2="64" y1="-32" y2="0" x1="128" />
            <line x2="128" y1="-64" y2="-32" x1="64" />
            <line x2="128" y1="-32" y2="-32" x1="224" />
            <line x2="64" y1="-32" y2="-32" x1="0" />
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
        <blockdef name="or3">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="48" y1="-64" y2="-64" x1="0" />
            <line x2="72" y1="-128" y2="-128" x1="0" />
            <line x2="48" y1="-192" y2="-192" x1="0" />
            <line x2="192" y1="-128" y2="-128" x1="256" />
            <arc ex="192" ey="-128" sx="112" sy="-80" r="88" cx="116" cy="-168" />
            <arc ex="48" ey="-176" sx="48" sy="-80" r="56" cx="16" cy="-128" />
            <line x2="48" y1="-64" y2="-80" x1="48" />
            <line x2="48" y1="-192" y2="-176" x1="48" />
            <line x2="48" y1="-80" y2="-80" x1="112" />
            <arc ex="112" ey="-176" sx="192" sy="-128" r="88" cx="116" cy="-88" />
            <line x2="48" y1="-176" y2="-176" x1="112" />
        </blockdef>
        <blockdef name="hex_7seg">
            <timestamp>2014-3-25T13:20:34</timestamp>
            <rect width="256" x="64" y="-64" height="64" />
            <rect width="64" x="0" y="-44" height="24" />
            <line x2="0" y1="-32" y2="-32" x1="64" />
            <rect width="64" x="320" y="-44" height="24" />
            <line x2="384" y1="-32" y2="-32" x1="320" />
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
        <block symbolname="ibuf" name="XLXI_1">
            <blockpin signalname="a" name="I" />
            <blockpin signalname="led(0)" name="O" />
        </block>
        <block symbolname="ibuf" name="XLXI_2">
            <blockpin signalname="b" name="I" />
            <blockpin signalname="led(1)" name="O" />
        </block>
        <block symbolname="ibuf" name="XLXI_3">
            <blockpin signalname="c" name="I" />
            <blockpin signalname="led(2)" name="O" />
        </block>
        <block symbolname="and2" name="XLXI_4">
            <blockpin signalname="led(1)" name="I0" />
            <blockpin signalname="led(0)" name="I1" />
            <blockpin signalname="XLXN_12" name="O" />
        </block>
        <block symbolname="and2" name="XLXI_5">
            <blockpin signalname="led(2)" name="I0" />
            <blockpin signalname="led(0)" name="I1" />
            <blockpin signalname="XLXN_13" name="O" />
        </block>
        <block symbolname="and2" name="XLXI_6">
            <blockpin signalname="led(2)" name="I0" />
            <blockpin signalname="led(1)" name="I1" />
            <blockpin signalname="XLXN_14" name="O" />
        </block>
        <block symbolname="or3" name="XLXI_7">
            <blockpin signalname="XLXN_14" name="I0" />
            <blockpin signalname="XLXN_13" name="I1" />
            <blockpin signalname="XLXN_12" name="I2" />
            <blockpin signalname="dd(0)" name="O" />
        </block>
        <block symbolname="hex_7seg" name="XLXI_8">
            <blockpin signalname="dd(3:0)" name="d(3:0)" />
            <blockpin signalname="seg(6:0)" name="s(6:0)" />
        </block>
        <block symbolname="gnd" name="XLXI_9">
            <blockpin signalname="dd(1)" name="G" />
        </block>
        <block symbolname="gnd" name="XLXI_10">
            <blockpin signalname="dd(2)" name="G" />
        </block>
        <block symbolname="gnd" name="XLXI_11">
            <blockpin signalname="dd(3)" name="G" />
        </block>
        <block symbolname="gnd" name="XLXI_12">
            <blockpin signalname="an0" name="G" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="7040" height="5440">
        <branch name="a">
            <wire x2="720" y1="304" y2="304" x1="352" />
        </branch>
        <branch name="b">
            <wire x2="720" y1="480" y2="480" x1="336" />
        </branch>
        <branch name="c">
            <wire x2="736" y1="672" y2="672" x1="352" />
        </branch>
        <iomarker fontsize="28" x="352" y="304" name="a" orien="R180" />
        <iomarker fontsize="28" x="336" y="480" name="b" orien="R180" />
        <iomarker fontsize="28" x="352" y="672" name="c" orien="R180" />
        <instance x="720" y="336" name="XLXI_1" orien="R0" />
        <instance x="720" y="512" name="XLXI_2" orien="R0" />
        <instance x="736" y="704" name="XLXI_3" orien="R0" />
        <instance x="2176" y="432" name="XLXI_4" orien="R0" />
        <instance x="2176" y="672" name="XLXI_5" orien="R0" />
        <instance x="2176" y="944" name="XLXI_6" orien="R0" />
        <instance x="2656" y="704" name="XLXI_7" orien="R0" />
        <branch name="XLXN_12">
            <wire x2="2656" y1="336" y2="336" x1="2432" />
            <wire x2="2656" y1="336" y2="512" x1="2656" />
        </branch>
        <branch name="XLXN_13">
            <wire x2="2656" y1="576" y2="576" x1="2432" />
        </branch>
        <branch name="XLXN_14">
            <wire x2="2656" y1="848" y2="848" x1="2432" />
            <wire x2="2656" y1="640" y2="848" x1="2656" />
        </branch>
        <instance x="3824" y="608" name="XLXI_8" orien="R0">
        </instance>
        <branch name="dd(3:0)">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3488" y="352" type="branch" />
            <wire x2="3488" y1="304" y2="352" x1="3488" />
            <wire x2="3488" y1="352" y2="400" x1="3488" />
            <wire x2="3488" y1="400" y2="448" x1="3488" />
            <wire x2="3488" y1="448" y2="496" x1="3488" />
            <wire x2="3488" y1="496" y2="544" x1="3488" />
            <wire x2="3488" y1="544" y2="752" x1="3488" />
            <wire x2="3648" y1="752" y2="752" x1="3488" />
            <wire x2="3648" y1="576" y2="752" x1="3648" />
            <wire x2="3824" y1="576" y2="576" x1="3648" />
        </branch>
        <bustap x2="3392" y1="400" y2="400" x1="3488" />
        <bustap x2="3392" y1="448" y2="448" x1="3488" />
        <bustap x2="3392" y1="496" y2="496" x1="3488" />
        <bustap x2="3392" y1="544" y2="544" x1="3488" />
        <branch name="dd(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3296" y="544" type="branch" />
            <wire x2="3296" y1="576" y2="576" x1="2912" />
            <wire x2="3392" y1="544" y2="544" x1="3296" />
            <wire x2="3296" y1="544" y2="576" x1="3296" />
        </branch>
        <branch name="dd(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3344" y="400" type="branch" />
            <wire x2="3152" y1="304" y2="400" x1="3152" />
            <wire x2="3344" y1="400" y2="400" x1="3152" />
            <wire x2="3392" y1="400" y2="400" x1="3344" />
        </branch>
        <branch name="dd(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3360" y="448" type="branch" />
            <wire x2="3072" y1="320" y2="448" x1="3072" />
            <wire x2="3360" y1="448" y2="448" x1="3072" />
            <wire x2="3392" y1="448" y2="448" x1="3360" />
        </branch>
        <branch name="dd(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3344" y="496" type="branch" />
            <wire x2="3008" y1="304" y2="496" x1="3008" />
            <wire x2="3344" y1="496" y2="496" x1="3008" />
            <wire x2="3392" y1="496" y2="496" x1="3344" />
        </branch>
        <instance x="3072" y="176" name="XLXI_9" orien="R180" />
        <instance x="3136" y="192" name="XLXI_10" orien="R180" />
        <instance x="3216" y="176" name="XLXI_11" orien="R180" />
        <branch name="seg(6:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="4272" y="576" type="branch" />
            <wire x2="4272" y1="576" y2="576" x1="4208" />
            <wire x2="4368" y1="576" y2="576" x1="4272" />
        </branch>
        <iomarker fontsize="28" x="4368" y="576" name="seg(6:0)" orien="R0" />
        <branch name="led(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2336" y="1120" type="branch" />
            <wire x2="1168" y1="304" y2="304" x1="944" />
            <wire x2="1232" y1="304" y2="304" x1="1168" />
            <wire x2="1744" y1="304" y2="304" x1="1232" />
            <wire x2="2016" y1="304" y2="304" x1="1744" />
            <wire x2="2176" y1="304" y2="304" x1="2016" />
            <wire x2="1744" y1="304" y2="544" x1="1744" />
            <wire x2="2176" y1="544" y2="544" x1="1744" />
            <wire x2="1168" y1="304" y2="1120" x1="1168" />
            <wire x2="1680" y1="1120" y2="1120" x1="1168" />
            <wire x2="2336" y1="1120" y2="1120" x1="1680" />
            <wire x2="2400" y1="1120" y2="1120" x1="2336" />
        </branch>
        <branch name="led(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2320" y="1280" type="branch" />
            <wire x2="1040" y1="480" y2="480" x1="944" />
            <wire x2="1248" y1="480" y2="480" x1="1040" />
            <wire x2="1728" y1="480" y2="480" x1="1248" />
            <wire x2="1728" y1="480" y2="816" x1="1728" />
            <wire x2="2176" y1="816" y2="816" x1="1728" />
            <wire x2="1040" y1="480" y2="1280" x1="1040" />
            <wire x2="1664" y1="1280" y2="1280" x1="1040" />
            <wire x2="2320" y1="1280" y2="1280" x1="1664" />
            <wire x2="2400" y1="1280" y2="1280" x1="2320" />
            <wire x2="2176" y1="368" y2="368" x1="1728" />
            <wire x2="1728" y1="368" y2="480" x1="1728" />
        </branch>
        <branch name="led(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2320" y="1424" type="branch" />
            <wire x2="976" y1="672" y2="672" x1="960" />
            <wire x2="1264" y1="672" y2="672" x1="976" />
            <wire x2="1632" y1="672" y2="672" x1="1264" />
            <wire x2="1632" y1="672" y2="880" x1="1632" />
            <wire x2="2176" y1="880" y2="880" x1="1632" />
            <wire x2="976" y1="672" y2="1424" x1="976" />
            <wire x2="1680" y1="1424" y2="1424" x1="976" />
            <wire x2="2320" y1="1424" y2="1424" x1="1680" />
            <wire x2="2400" y1="1424" y2="1424" x1="2320" />
            <wire x2="2176" y1="608" y2="608" x1="1632" />
            <wire x2="1632" y1="608" y2="672" x1="1632" />
        </branch>
        <iomarker fontsize="28" x="2400" y="1120" name="led(0)" orien="R0" />
        <iomarker fontsize="28" x="2400" y="1280" name="led(1)" orien="R0" />
        <iomarker fontsize="28" x="2400" y="1424" name="led(2)" orien="R0" />
        <branch name="an0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3568" y="1120" type="branch" />
            <wire x2="3568" y1="1120" y2="1120" x1="3104" />
            <wire x2="3648" y1="1120" y2="1120" x1="3568" />
        </branch>
        <instance x="3168" y="992" name="XLXI_12" orien="R180" />
        <iomarker fontsize="28" x="3648" y="1120" name="an0" orien="R0" />
    </sheet>
</drawing>