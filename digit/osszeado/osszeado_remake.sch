<?xml version="1.0" encoding="UTF-8"?>
<drawing version="7">
    <attr value="spartan3e" name="DeviceFamilyName">
        <trait delete="all:0" />
        <trait editname="all:0" />
        <trait edittrait="all:0" />
    </attr>
    <netlist>
        <signal name="A(0)" />
        <signal name="A(1)" />
        <signal name="XLXN_7" />
        <signal name="B(1)" />
        <signal name="XLXN_9" />
        <signal name="B(3:0)" />
        <signal name="A(3:0)" />
        <signal name="B(0)" />
        <signal name="XLXN_15" />
        <signal name="XLXN_16" />
        <signal name="XLXN_17" />
        <signal name="XLXN_18" />
        <signal name="out(3:0)" />
        <signal name="XLXN_20" />
        <signal name="XLXN_21" />
        <signal name="XLXN_22" />
        <signal name="seg(3:0)" />
        <signal name="an0" />
        <signal name="an2" />
        <signal name="an3" />
        <signal name="an1" />
        <signal name="XLXN_28" />
        <signal name="XLXN_29" />
        <signal name="XLXN_30" />
        <signal name="XLXN_31" />
        <port polarity="Input" name="B(3:0)" />
        <port polarity="Input" name="A(3:0)" />
        <port polarity="Output" name="seg(3:0)" />
        <port polarity="Output" name="an0" />
        <port polarity="Output" name="an2" />
        <port polarity="Output" name="an3" />
        <port polarity="Output" name="an1" />
        <blockdef name="add4">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="112" y1="-832" y2="-804" x1="112" />
            <line x2="112" y1="-832" y2="-832" x1="64" />
            <line x2="64" y1="-832" y2="-832" x1="0" />
            <line x2="64" y1="-192" y2="-192" x1="0" />
            <line x2="384" y1="-352" y2="-352" x1="448" />
            <line x2="384" y1="-416" y2="-416" x1="448" />
            <line x2="384" y1="-480" y2="-480" x1="448" />
            <line x2="384" y1="-544" y2="-544" x1="448" />
            <line x2="64" y1="-256" y2="-256" x1="0" />
            <line x2="64" y1="-320" y2="-320" x1="0" />
            <line x2="64" y1="-384" y2="-384" x1="0" />
            <line x2="64" y1="-512" y2="-512" x1="0" />
            <line x2="64" y1="-576" y2="-576" x1="0" />
            <line x2="64" y1="-640" y2="-640" x1="0" />
            <line x2="64" y1="-704" y2="-704" x1="0" />
            <line x2="384" y1="-64" y2="-64" x1="240" />
            <line x2="240" y1="-124" y2="-64" x1="240" />
            <line x2="336" y1="-128" y2="-148" x1="336" />
            <line x2="336" y1="-128" y2="-128" x1="384" />
            <line x2="64" y1="-736" y2="-816" x1="384" />
            <line x2="384" y1="-160" y2="-736" x1="384" />
            <line x2="384" y1="-80" y2="-160" x1="64" />
            <line x2="64" y1="-416" y2="-80" x1="64" />
            <line x2="64" y1="-448" y2="-416" x1="144" />
            <line x2="144" y1="-480" y2="-448" x1="64" />
            <line x2="64" y1="-816" y2="-480" x1="64" />
            <line x2="384" y1="-64" y2="-64" x1="448" />
            <line x2="384" y1="-128" y2="-128" x1="448" />
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
        <blockdef name="gnd">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-64" y2="-96" x1="64" />
            <line x2="52" y1="-48" y2="-48" x1="76" />
            <line x2="60" y1="-32" y2="-32" x1="68" />
            <line x2="40" y1="-64" y2="-64" x1="88" />
            <line x2="64" y1="-64" y2="-80" x1="64" />
            <line x2="64" y1="-128" y2="-96" x1="64" />
        </blockdef>
        <block symbolname="add4" name="XLXI_1">
            <blockpin signalname="A(0)" name="A0" />
            <blockpin signalname="A(1)" name="A1" />
            <blockpin signalname="XLXN_28" name="A2" />
            <blockpin signalname="XLXN_29" name="A3" />
            <blockpin signalname="B(0)" name="B0" />
            <blockpin signalname="B(1)" name="B1" />
            <blockpin signalname="XLXN_30" name="B2" />
            <blockpin signalname="XLXN_31" name="B3" />
            <blockpin name="CI" />
            <blockpin name="CO" />
            <blockpin name="OFL" />
            <blockpin signalname="XLXN_15" name="S0" />
            <blockpin signalname="XLXN_20" name="S1" />
            <blockpin signalname="XLXN_21" name="S2" />
            <blockpin signalname="XLXN_22" name="S3" />
        </block>
        <block symbolname="hex_7seg" name="XLXI_2">
            <blockpin signalname="out(3:0)" name="d(3:0)" />
            <blockpin signalname="seg(3:0)" name="s(6:0)" />
        </block>
        <block symbolname="vcc" name="XLXI_3">
            <blockpin signalname="an0" name="P" />
        </block>
        <block symbolname="vcc" name="XLXI_4">
            <blockpin signalname="an2" name="P" />
        </block>
        <block symbolname="vcc" name="XLXI_5">
            <blockpin signalname="an3" name="P" />
        </block>
        <block symbolname="gnd" name="XLXI_6">
            <blockpin signalname="an1" name="G" />
        </block>
        <block symbolname="gnd" name="XLXI_7">
            <blockpin signalname="XLXN_28" name="G" />
        </block>
        <block symbolname="gnd" name="XLXI_8">
            <blockpin signalname="XLXN_29" name="G" />
        </block>
        <block symbolname="gnd" name="XLXI_9">
            <blockpin signalname="XLXN_30" name="G" />
        </block>
        <block symbolname="gnd" name="XLXI_10">
            <blockpin signalname="XLXN_31" name="G" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="7040" height="5440">
        <instance x="1328" y="1344" name="XLXI_1" orien="R0" />
        <branch name="A(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="944" y="624" type="branch" />
            <wire x2="944" y1="624" y2="624" x1="848" />
            <wire x2="1040" y1="624" y2="624" x1="944" />
            <wire x2="1040" y1="624" y2="640" x1="1040" />
            <wire x2="1328" y1="640" y2="640" x1="1040" />
        </branch>
        <branch name="A(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="960" y="688" type="branch" />
            <wire x2="960" y1="688" y2="688" x1="848" />
            <wire x2="1040" y1="688" y2="688" x1="960" />
            <wire x2="1040" y1="688" y2="704" x1="1040" />
            <wire x2="1328" y1="704" y2="704" x1="1040" />
        </branch>
        <branch name="B(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1056" y="1024" type="branch" />
            <wire x2="1040" y1="1104" y2="1104" x1="848" />
            <wire x2="1040" y1="1024" y2="1104" x1="1040" />
            <wire x2="1056" y1="1024" y2="1024" x1="1040" />
            <wire x2="1328" y1="1024" y2="1024" x1="1056" />
        </branch>
        <branch name="B(3:0)">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="752" y="992" type="branch" />
            <wire x2="752" y1="1312" y2="1312" x1="592" />
            <wire x2="752" y1="944" y2="992" x1="752" />
            <wire x2="752" y1="992" y2="1056" x1="752" />
            <wire x2="752" y1="1056" y2="1104" x1="752" />
            <wire x2="752" y1="1104" y2="1152" x1="752" />
            <wire x2="752" y1="1152" y2="1200" x1="752" />
            <wire x2="752" y1="1200" y2="1312" x1="752" />
        </branch>
        <branch name="A(3:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="656" y="560" type="branch" />
            <wire x2="656" y1="560" y2="560" x1="576" />
            <wire x2="752" y1="560" y2="560" x1="656" />
            <wire x2="752" y1="560" y2="624" x1="752" />
            <wire x2="752" y1="624" y2="688" x1="752" />
            <wire x2="752" y1="688" y2="752" x1="752" />
            <wire x2="752" y1="752" y2="816" x1="752" />
            <wire x2="752" y1="816" y2="864" x1="752" />
        </branch>
        <bustap x2="848" y1="624" y2="624" x1="752" />
        <bustap x2="848" y1="688" y2="688" x1="752" />
        <bustap x2="848" y1="1056" y2="1056" x1="752" />
        <bustap x2="848" y1="1104" y2="1104" x1="752" />
        <branch name="B(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="960" y="960" type="branch" />
            <wire x2="944" y1="1056" y2="1056" x1="848" />
            <wire x2="944" y1="960" y2="1056" x1="944" />
            <wire x2="960" y1="960" y2="960" x1="944" />
            <wire x2="1040" y1="960" y2="960" x1="960" />
            <wire x2="1328" y1="960" y2="960" x1="1040" />
        </branch>
        <iomarker fontsize="28" x="592" y="1312" name="B(3:0)" orien="R180" />
        <iomarker fontsize="28" x="576" y="560" name="A(3:0)" orien="R180" />
        <branch name="XLXN_15">
            <wire x2="2000" y1="800" y2="800" x1="1776" />
            <wire x2="2048" y1="800" y2="800" x1="2000" />
            <wire x2="2048" y1="800" y2="864" x1="2048" />
            <wire x2="2096" y1="864" y2="864" x1="2048" />
        </branch>
        <branch name="out(3:0)">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2192" y="816" type="branch" />
            <wire x2="2192" y1="784" y2="816" x1="2192" />
            <wire x2="2192" y1="816" y2="864" x1="2192" />
            <wire x2="2192" y1="864" y2="912" x1="2192" />
            <wire x2="2192" y1="912" y2="944" x1="2192" />
            <wire x2="2192" y1="944" y2="976" x1="2192" />
            <wire x2="2192" y1="976" y2="1024" x1="2192" />
        </branch>
        <bustap x2="2096" y1="864" y2="864" x1="2192" />
        <bustap x2="2096" y1="912" y2="912" x1="2192" />
        <bustap x2="2096" y1="944" y2="944" x1="2192" />
        <bustap x2="2096" y1="976" y2="976" x1="2192" />
        <branch name="XLXN_20">
            <wire x2="2000" y1="864" y2="864" x1="1776" />
            <wire x2="2000" y1="864" y2="912" x1="2000" />
            <wire x2="2096" y1="912" y2="912" x1="2000" />
        </branch>
        <branch name="XLXN_21">
            <wire x2="2016" y1="928" y2="928" x1="1776" />
            <wire x2="2016" y1="928" y2="944" x1="2016" />
            <wire x2="2096" y1="944" y2="944" x1="2016" />
        </branch>
        <branch name="XLXN_22">
            <wire x2="2016" y1="992" y2="992" x1="1776" />
            <wire x2="2096" y1="976" y2="976" x1="2016" />
            <wire x2="2016" y1="976" y2="992" x1="2016" />
        </branch>
        <instance x="2192" y="1056" name="XLXI_2" orien="R0">
        </instance>
        <branch name="seg(3:0)">
            <wire x2="2704" y1="1024" y2="1024" x1="2576" />
        </branch>
        <iomarker fontsize="28" x="2704" y="1024" name="seg(3:0)" orien="R0" />
        <branch name="an0">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2352" y="1280" type="branch" />
            <wire x2="2352" y1="1168" y2="1280" x1="2352" />
            <wire x2="2352" y1="1280" y2="1344" x1="2352" />
        </branch>
        <branch name="an2">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2480" y="1248" type="branch" />
            <wire x2="2480" y1="1168" y2="1248" x1="2480" />
            <wire x2="2480" y1="1248" y2="1344" x1="2480" />
        </branch>
        <branch name="an3">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2576" y="1248" type="branch" />
            <wire x2="2576" y1="1168" y2="1248" x1="2576" />
            <wire x2="2576" y1="1248" y2="1344" x1="2576" />
        </branch>
        <branch name="an1">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2240" y="1232" type="branch" />
            <wire x2="2240" y1="1152" y2="1232" x1="2240" />
            <wire x2="2240" y1="1232" y2="1344" x1="2240" />
        </branch>
        <instance x="2288" y="1168" name="XLXI_3" orien="R0" />
        <instance x="2416" y="1168" name="XLXI_4" orien="R0" />
        <instance x="2512" y="1168" name="XLXI_5" orien="R0" />
        <instance x="2176" y="1472" name="XLXI_6" orien="R0" />
        <iomarker fontsize="28" x="2240" y="1152" name="an1" orien="R270" />
        <iomarker fontsize="28" x="2352" y="1344" name="an0" orien="R90" />
        <iomarker fontsize="28" x="2480" y="1344" name="an2" orien="R90" />
        <iomarker fontsize="28" x="2576" y="1344" name="an3" orien="R90" />
        <branch name="XLXN_28">
            <wire x2="1328" y1="768" y2="768" x1="1184" />
        </branch>
        <branch name="XLXN_29">
            <wire x2="1328" y1="832" y2="832" x1="1232" />
        </branch>
        <instance x="1120" y="896" name="XLXI_7" orien="R0" />
        <instance x="1168" y="960" name="XLXI_8" orien="R0" />
        <branch name="XLXN_30">
            <wire x2="1328" y1="1088" y2="1088" x1="1136" />
        </branch>
        <branch name="XLXN_31">
            <wire x2="1328" y1="1152" y2="1152" x1="1248" />
        </branch>
        <instance x="1072" y="1216" name="XLXI_9" orien="R0" />
        <instance x="1184" y="1280" name="XLXI_10" orien="R0" />
    </sheet>
</drawing>