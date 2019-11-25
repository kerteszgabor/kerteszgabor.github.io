<?xml version="1.0" encoding="UTF-8"?>
<drawing version="7">
    <attr value="spartan3e" name="DeviceFamilyName">
        <trait delete="all:0" />
        <trait editname="all:0" />
        <trait edittrait="all:0" />
    </attr>
    <netlist>
        <signal name="A(3:0)" />
        <signal name="A(1)" />
        <signal name="A(2)" />
        <signal name="A(3)" />
        <signal name="RR(0)">
        </signal>
        <signal name="RR(1)">
        </signal>
        <signal name="RR(2)">
        </signal>
        <signal name="RR(3)" />
        <signal name="RR(3:0)">
        </signal>
        <signal name="A(0)" />
        <signal name="RL(1)" />
        <signal name="RL(2)" />
        <signal name="RL(3)" />
        <signal name="RL(0)" />
        <signal name="RL(3:0)">
        </signal>
        <signal name="XLXN_21(3:0)" />
        <signal name="st" />
        <signal name="XLXN_23" />
        <signal name="XLXN_24(3:0)" />
        <signal name="seg(6:0)" />
        <port polarity="Input" name="A(3:0)" />
        <port polarity="Input" name="st" />
        <port polarity="Output" name="seg(6:0)" />
        <blockdef name="buf">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-32" y2="-32" x1="0" />
            <line x2="128" y1="-32" y2="-32" x1="224" />
            <line x2="128" y1="0" y2="-32" x1="64" />
            <line x2="64" y1="-32" y2="-64" x1="128" />
            <line x2="64" y1="-64" y2="0" x1="64" />
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
        <blockdef name="mplx_2_1_4bit">
            <timestamp>2014-5-19T12:36:38</timestamp>
            <rect width="256" x="64" y="-192" height="192" />
            <rect width="64" x="0" y="-172" height="24" />
            <line x2="0" y1="-160" y2="-160" x1="64" />
            <rect width="64" x="0" y="-108" height="24" />
            <line x2="0" y1="-96" y2="-96" x1="64" />
            <line x2="0" y1="-32" y2="-32" x1="64" />
            <rect width="64" x="320" y="-172" height="24" />
            <line x2="384" y1="-160" y2="-160" x1="320" />
        </blockdef>
        <blockdef name="hex_7seg">
            <timestamp>2014-3-25T13:20:34</timestamp>
            <rect width="256" x="64" y="-64" height="64" />
            <rect width="64" x="0" y="-44" height="24" />
            <line x2="0" y1="-32" y2="-32" x1="64" />
            <rect width="64" x="320" y="-44" height="24" />
            <line x2="384" y1="-32" y2="-32" x1="320" />
        </blockdef>
        <block symbolname="buf" name="XLXI_1">
            <blockpin signalname="A(1)" name="I" />
            <blockpin signalname="RR(0)" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_2">
            <blockpin signalname="A(2)" name="I" />
            <blockpin signalname="RR(1)" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_3">
            <blockpin signalname="A(3)" name="I" />
            <blockpin signalname="RR(2)" name="O" />
        </block>
        <block symbolname="gnd" name="XLXI_4">
            <blockpin signalname="RR(3)" name="G" />
        </block>
        <block symbolname="buf" name="XLXI_5">
            <blockpin signalname="A(0)" name="I" />
            <blockpin signalname="RL(1)" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_6">
            <blockpin signalname="A(1)" name="I" />
            <blockpin signalname="RL(2)" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_7">
            <blockpin signalname="A(2)" name="I" />
            <blockpin signalname="RL(3)" name="O" />
        </block>
        <block symbolname="gnd" name="XLXI_8">
            <blockpin signalname="RL(0)" name="G" />
        </block>
        <block symbolname="mplx_2_1_4bit" name="XLXI_9">
            <blockpin signalname="RR(3:0)" name="ain(3:0)" />
            <blockpin signalname="RL(3:0)" name="bin(3:0)" />
            <blockpin signalname="st" name="sel" />
            <blockpin signalname="XLXN_24(3:0)" name="ki(3:0)" />
        </block>
        <block symbolname="hex_7seg" name="XLXI_10">
            <blockpin signalname="XLXN_24(3:0)" name="d(3:0)" />
            <blockpin signalname="seg(6:0)" name="s(6:0)" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="7040" height="5440">
        <branch name="A(3:0)">
            <wire x2="1504" y1="1104" y2="1104" x1="368" />
        </branch>
        <iomarker fontsize="28" x="368" y="1104" name="A(3:0)" orien="R180" />
        <branch name="A(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1840" y="1104" type="branch" />
            <wire x2="1840" y1="1104" y2="1104" x1="1824" />
            <wire x2="2176" y1="1104" y2="1104" x1="1840" />
        </branch>
        <branch name="A(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1872" y="1232" type="branch" />
            <wire x2="1872" y1="1232" y2="1232" x1="1840" />
            <wire x2="2176" y1="1232" y2="1232" x1="1872" />
        </branch>
        <branch name="A(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1856" y="1360" type="branch" />
            <wire x2="1856" y1="1360" y2="1360" x1="1840" />
            <wire x2="2176" y1="1360" y2="1360" x1="1856" />
        </branch>
        <instance x="2176" y="1136" name="XLXI_1" orien="R0" />
        <instance x="2176" y="1264" name="XLXI_2" orien="R0" />
        <instance x="2176" y="1392" name="XLXI_3" orien="R0" />
        <branch name="RR(0)">
            <attrtext style="alignment:SOFT-LEFT;fontsize:28;fontname:Arial" attrname="Name" x="2608" y="1104" type="branch" />
            <wire x2="2608" y1="1104" y2="1104" x1="2400" />
        </branch>
        <branch name="RR(1)">
            <attrtext style="alignment:SOFT-LEFT;fontsize:28;fontname:Arial" attrname="Name" x="2624" y="1232" type="branch" />
            <wire x2="2624" y1="1232" y2="1232" x1="2400" />
        </branch>
        <branch name="RR(2)">
            <attrtext style="alignment:SOFT-LEFT;fontsize:28;fontname:Arial" attrname="Name" x="2624" y="1360" type="branch" />
            <wire x2="2624" y1="1360" y2="1360" x1="2400" />
        </branch>
        <branch name="RR(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2336" y="1536" type="branch" />
            <wire x2="2336" y1="1536" y2="1536" x1="1824" />
            <wire x2="2368" y1="1536" y2="1536" x1="2336" />
        </branch>
        <instance x="1760" y="1664" name="XLXI_4" orien="R0" />
        <branch name="RR(3:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2816" y="832" type="branch" />
            <wire x2="2816" y1="832" y2="832" x1="2640" />
            <wire x2="3104" y1="832" y2="832" x1="2816" />
            <wire x2="3216" y1="832" y2="832" x1="3104" />
        </branch>
        <branch name="A(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1856" y="1840" type="branch" />
            <wire x2="1856" y1="1840" y2="1840" x1="1824" />
            <wire x2="2256" y1="1840" y2="1840" x1="1856" />
        </branch>
        <branch name="A(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1840" y="1936" type="branch" />
            <wire x2="1840" y1="1936" y2="1936" x1="1808" />
            <wire x2="2240" y1="1936" y2="1936" x1="1840" />
        </branch>
        <branch name="A(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1840" y="2016" type="branch" />
            <wire x2="1840" y1="2016" y2="2016" x1="1808" />
            <wire x2="2256" y1="2016" y2="2016" x1="1840" />
        </branch>
        <instance x="2256" y="1872" name="XLXI_5" orien="R0" />
        <instance x="2240" y="1968" name="XLXI_6" orien="R0" />
        <instance x="2256" y="2048" name="XLXI_7" orien="R0" />
        <branch name="RL(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2672" y="1840" type="branch" />
            <wire x2="2672" y1="1840" y2="1840" x1="2480" />
            <wire x2="2704" y1="1840" y2="1840" x1="2672" />
        </branch>
        <branch name="RL(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2640" y="1936" type="branch" />
            <wire x2="2640" y1="1936" y2="1936" x1="2464" />
            <wire x2="2704" y1="1936" y2="1936" x1="2640" />
        </branch>
        <branch name="RL(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2640" y="2016" type="branch" />
            <wire x2="2640" y1="2016" y2="2016" x1="2480" />
            <wire x2="2704" y1="2016" y2="2016" x1="2640" />
        </branch>
        <branch name="RL(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2176" y="2144" type="branch" />
            <wire x2="2176" y1="2144" y2="2144" x1="1840" />
            <wire x2="2288" y1="2144" y2="2144" x1="2176" />
        </branch>
        <instance x="1776" y="2272" name="XLXI_8" orien="R0" />
        <branch name="RL(3:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2880" y="928" type="branch" />
            <wire x2="2880" y1="928" y2="928" x1="2624" />
            <wire x2="3088" y1="928" y2="928" x1="2880" />
            <wire x2="3216" y1="896" y2="896" x1="3088" />
            <wire x2="3088" y1="896" y2="928" x1="3088" />
        </branch>
        <instance x="3216" y="992" name="XLXI_9" orien="R0">
        </instance>
        <branch name="st">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3088" y="1200" type="branch" />
            <wire x2="3216" y1="960" y2="960" x1="3088" />
            <wire x2="3088" y1="960" y2="1072" x1="3088" />
            <wire x2="3088" y1="1072" y2="1200" x1="3088" />
            <wire x2="3088" y1="1200" y2="1216" x1="3088" />
        </branch>
        <iomarker fontsize="28" x="3088" y="1216" name="st" orien="R90" />
        <branch name="XLXN_24(3:0)">
            <wire x2="3824" y1="832" y2="832" x1="3600" />
        </branch>
        <instance x="3824" y="864" name="XLXI_10" orien="R0">
        </instance>
        <branch name="seg(6:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="4336" y="832" type="branch" />
            <wire x2="4336" y1="832" y2="832" x1="4208" />
            <wire x2="4416" y1="832" y2="832" x1="4336" />
        </branch>
        <iomarker fontsize="28" x="4416" y="832" name="seg(6:0)" orien="R0" />
    </sheet>
</drawing>