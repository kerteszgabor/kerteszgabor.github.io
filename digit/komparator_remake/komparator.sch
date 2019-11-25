<?xml version="1.0" encoding="UTF-8"?>
<drawing version="7">
    <attr value="spartan3e" name="DeviceFamilyName">
        <trait delete="all:0" />
        <trait editname="all:0" />
        <trait edittrait="all:0" />
    </attr>
    <netlist>
        <signal name="A(3:0)" />
        <signal name="B(3:0)" />
        <signal name="A(0)" />
        <signal name="A(1)" />
        <signal name="A(2)" />
        <signal name="A(3)" />
        <signal name="B(0)" />
        <signal name="B(1)" />
        <signal name="B(2)" />
        <signal name="B(3)" />
        <signal name="out0" />
        <signal name="out1" />
        <signal name="out2" />
        <signal name="out3" />
        <signal name="out4" />
        <signal name="out6" />
        <signal name="out7" />
        <signal name="out5" />
        <signal name="n" />
        <signal name="k" />
        <signal name="XLXN_44" />
        <signal name="XLXN_45" />
        <signal name="XLXN_46" />
        <signal name="XLXN_49" />
        <signal name="XLXN_50" />
        <signal name="XLXN_51" />
        <signal name="e" />
        <signal name="an(3)" />
        <signal name="an(2)" />
        <signal name="an(1)" />
        <signal name="an(0)" />
        <port polarity="Input" name="A(3:0)" />
        <port polarity="Input" name="B(3:0)" />
        <port polarity="Output" name="out0" />
        <port polarity="Output" name="out1" />
        <port polarity="Output" name="out2" />
        <port polarity="Output" name="out3" />
        <port polarity="Output" name="out4" />
        <port polarity="Output" name="out6" />
        <port polarity="Output" name="out7" />
        <port polarity="Output" name="out5" />
        <port polarity="Output" name="n" />
        <port polarity="Output" name="k" />
        <port polarity="Output" name="e" />
        <port polarity="Output" name="an(3)" />
        <port polarity="Output" name="an(2)" />
        <port polarity="Output" name="an(1)" />
        <port polarity="Output" name="an(0)" />
        <blockdef name="buf">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-32" y2="-32" x1="0" />
            <line x2="128" y1="-32" y2="-32" x1="224" />
            <line x2="128" y1="0" y2="-32" x1="64" />
            <line x2="64" y1="-32" y2="-64" x1="128" />
            <line x2="64" y1="-64" y2="0" x1="64" />
        </blockdef>
        <blockdef name="compm4">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-256" y2="-256" x1="0" />
            <line x2="64" y1="-320" y2="-320" x1="0" />
            <line x2="64" y1="-512" y2="-512" x1="0" />
            <line x2="64" y1="-576" y2="-576" x1="0" />
            <line x2="64" y1="-448" y2="-448" x1="0" />
            <line x2="64" y1="-384" y2="-384" x1="0" />
            <line x2="64" y1="-192" y2="-192" x1="0" />
            <line x2="64" y1="-128" y2="-128" x1="0" />
            <rect width="256" x="64" y="-640" height="576" />
            <line x2="320" y1="-320" y2="-320" x1="384" />
            <line x2="320" y1="-384" y2="-384" x1="384" />
        </blockdef>
        <blockdef name="inv">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-32" y2="-32" x1="0" />
            <line x2="160" y1="-32" y2="-32" x1="224" />
            <line x2="128" y1="-64" y2="-32" x1="64" />
            <line x2="64" y1="-32" y2="0" x1="128" />
            <line x2="64" y1="0" y2="-64" x1="64" />
            <circle r="16" cx="144" cy="-32" />
        </blockdef>
        <blockdef name="and2b2">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="40" y1="-64" y2="-64" x1="0" />
            <circle r="12" cx="52" cy="-64" />
            <line x2="40" y1="-128" y2="-128" x1="0" />
            <circle r="12" cx="52" cy="-128" />
            <line x2="192" y1="-96" y2="-96" x1="256" />
            <arc ex="144" ey="-144" sx="144" sy="-48" r="48" cx="144" cy="-96" />
            <line x2="64" y1="-48" y2="-144" x1="64" />
            <line x2="64" y1="-48" y2="-48" x1="144" />
            <line x2="144" y1="-144" y2="-144" x1="64" />
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
        <block symbolname="buf" name="XLXI_1">
            <blockpin signalname="A(0)" name="I" />
            <blockpin signalname="out0" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_2">
            <blockpin signalname="A(1)" name="I" />
            <blockpin signalname="out1" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_3">
            <blockpin signalname="A(2)" name="I" />
            <blockpin signalname="out2" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_4">
            <blockpin signalname="A(3)" name="I" />
            <blockpin signalname="out3" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_5">
            <blockpin signalname="B(0)" name="I" />
            <blockpin signalname="out4" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_7">
            <blockpin signalname="B(2)" name="I" />
            <blockpin signalname="out6" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_8">
            <blockpin signalname="B(3)" name="I" />
            <blockpin signalname="out7" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_6">
            <blockpin signalname="B(1)" name="I" />
            <blockpin signalname="out5" name="O" />
        </block>
        <block symbolname="compm4" name="XLXI_13">
            <blockpin signalname="A(0)" name="A0" />
            <blockpin signalname="A(1)" name="A1" />
            <blockpin signalname="A(2)" name="A2" />
            <blockpin signalname="A(3)" name="A3" />
            <blockpin signalname="B(0)" name="B0" />
            <blockpin signalname="B(1)" name="B1" />
            <blockpin signalname="B(2)" name="B2" />
            <blockpin signalname="B(3)" name="B3" />
            <blockpin signalname="n" name="GT" />
            <blockpin signalname="k" name="LT" />
        </block>
        <block symbolname="inv" name="XLXI_16">
            <blockpin signalname="n" name="I" />
            <blockpin signalname="XLXN_45" name="O" />
        </block>
        <block symbolname="inv" name="XLXI_17">
            <blockpin signalname="k" name="I" />
            <blockpin signalname="XLXN_46" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_18">
            <blockpin signalname="XLXN_45" name="I" />
            <blockpin signalname="n" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_19">
            <blockpin signalname="XLXN_46" name="I" />
            <blockpin signalname="k" name="O" />
        </block>
        <block symbolname="and2b2" name="XLXI_20">
            <blockpin signalname="k" name="I0" />
            <blockpin signalname="n" name="I1" />
            <blockpin signalname="XLXN_50" name="O" />
        </block>
        <block symbolname="inv" name="XLXI_21">
            <blockpin signalname="XLXN_50" name="I" />
            <blockpin signalname="XLXN_51" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_22">
            <blockpin signalname="XLXN_51" name="I" />
            <blockpin signalname="e" name="O" />
        </block>
        <block symbolname="vcc" name="XLXI_23">
            <blockpin signalname="an(3)" name="P" />
        </block>
        <block symbolname="vcc" name="XLXI_24">
            <blockpin signalname="an(2)" name="P" />
        </block>
        <block symbolname="vcc" name="XLXI_25">
            <blockpin signalname="an(1)" name="P" />
        </block>
        <block symbolname="gnd" name="XLXI_26">
            <blockpin signalname="an(0)" name="G" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="7040" height="5440">
        <branch name="A(3:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="336" y="336" type="branch" />
            <wire x2="336" y1="336" y2="336" x1="288" />
            <wire x2="816" y1="336" y2="336" x1="336" />
            <wire x2="1312" y1="336" y2="336" x1="816" />
            <wire x2="1312" y1="336" y2="432" x1="1312" />
            <wire x2="1312" y1="432" y2="528" x1="1312" />
            <wire x2="1312" y1="528" y2="624" x1="1312" />
            <wire x2="1312" y1="624" y2="704" x1="1312" />
            <wire x2="1312" y1="704" y2="1088" x1="1312" />
        </branch>
        <branch name="B(3:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="368" y="544" type="branch" />
            <wire x2="368" y1="544" y2="544" x1="288" />
            <wire x2="800" y1="544" y2="544" x1="368" />
            <wire x2="800" y1="544" y2="608" x1="800" />
            <wire x2="800" y1="608" y2="672" x1="800" />
            <wire x2="800" y1="672" y2="768" x1="800" />
            <wire x2="800" y1="768" y2="864" x1="800" />
            <wire x2="800" y1="864" y2="1104" x1="800" />
        </branch>
        <iomarker fontsize="28" x="288" y="336" name="A(3:0)" orien="R180" />
        <iomarker fontsize="28" x="288" y="544" name="B(3:0)" orien="R180" />
        <bustap x2="1408" y1="432" y2="432" x1="1312" />
        <bustap x2="1408" y1="528" y2="528" x1="1312" />
        <bustap x2="1408" y1="624" y2="624" x1="1312" />
        <bustap x2="1408" y1="704" y2="704" x1="1312" />
        <branch name="A(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1568" y="432" type="branch" />
            <wire x2="1568" y1="432" y2="432" x1="1408" />
            <wire x2="1840" y1="432" y2="432" x1="1568" />
        </branch>
        <branch name="A(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1568" y="528" type="branch" />
            <wire x2="1568" y1="528" y2="528" x1="1408" />
            <wire x2="1824" y1="528" y2="528" x1="1568" />
        </branch>
        <branch name="A(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1568" y="624" type="branch" />
            <wire x2="1568" y1="624" y2="624" x1="1408" />
            <wire x2="1840" y1="624" y2="624" x1="1568" />
        </branch>
        <branch name="A(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1568" y="704" type="branch" />
            <wire x2="1568" y1="704" y2="704" x1="1408" />
            <wire x2="1840" y1="704" y2="704" x1="1568" />
        </branch>
        <bustap x2="896" y1="608" y2="608" x1="800" />
        <bustap x2="896" y1="672" y2="672" x1="800" />
        <bustap x2="896" y1="768" y2="768" x1="800" />
        <bustap x2="896" y1="864" y2="864" x1="800" />
        <branch name="B(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="976" y="608" type="branch" />
            <wire x2="976" y1="608" y2="608" x1="896" />
            <wire x2="1040" y1="608" y2="608" x1="976" />
        </branch>
        <branch name="B(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="960" y="672" type="branch" />
            <wire x2="960" y1="672" y2="672" x1="896" />
            <wire x2="1024" y1="672" y2="672" x1="960" />
        </branch>
        <branch name="B(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="960" y="768" type="branch" />
            <wire x2="960" y1="768" y2="768" x1="896" />
            <wire x2="1024" y1="768" y2="768" x1="960" />
        </branch>
        <branch name="B(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="976" y="864" type="branch" />
            <wire x2="976" y1="864" y2="864" x1="896" />
            <wire x2="1024" y1="864" y2="864" x1="976" />
        </branch>
        <branch name="out0">
            <wire x2="1776" y1="112" y2="112" x1="1760" />
            <wire x2="2432" y1="112" y2="112" x1="1776" />
        </branch>
        <branch name="out1">
            <wire x2="1776" y1="192" y2="192" x1="1760" />
            <wire x2="2432" y1="192" y2="192" x1="1776" />
        </branch>
        <branch name="out2">
            <wire x2="1776" y1="256" y2="256" x1="1760" />
            <wire x2="2432" y1="256" y2="256" x1="1776" />
        </branch>
        <branch name="out3">
            <wire x2="1776" y1="320" y2="320" x1="1760" />
            <wire x2="2432" y1="320" y2="320" x1="1776" />
        </branch>
        <instance x="1552" y="144" name="XLXI_1" orien="R0" />
        <instance x="1552" y="224" name="XLXI_2" orien="R0" />
        <instance x="1552" y="288" name="XLXI_3" orien="R0" />
        <instance x="1552" y="352" name="XLXI_4" orien="R0" />
        <branch name="A(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1472" y="112" type="branch" />
            <wire x2="1472" y1="112" y2="112" x1="1440" />
            <wire x2="1552" y1="112" y2="112" x1="1472" />
        </branch>
        <branch name="A(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1472" y="192" type="branch" />
            <wire x2="1472" y1="192" y2="192" x1="1440" />
            <wire x2="1552" y1="192" y2="192" x1="1472" />
        </branch>
        <branch name="A(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1472" y="256" type="branch" />
            <wire x2="1472" y1="256" y2="256" x1="1440" />
            <wire x2="1552" y1="256" y2="256" x1="1472" />
        </branch>
        <branch name="A(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1472" y="320" type="branch" />
            <wire x2="1472" y1="320" y2="320" x1="1440" />
            <wire x2="1552" y1="320" y2="320" x1="1472" />
        </branch>
        <iomarker fontsize="28" x="2432" y="112" name="out0" orien="R0" />
        <iomarker fontsize="28" x="2432" y="192" name="out1" orien="R0" />
        <iomarker fontsize="28" x="2432" y="256" name="out2" orien="R0" />
        <iomarker fontsize="28" x="2432" y="320" name="out3" orien="R0" />
        <branch name="out4">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3728" y="128" type="branch" />
            <wire x2="3728" y1="128" y2="128" x1="3200" />
            <wire x2="3840" y1="128" y2="128" x1="3728" />
        </branch>
        <branch name="out6">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3712" y="272" type="branch" />
            <wire x2="3712" y1="272" y2="272" x1="3168" />
            <wire x2="3840" y1="272" y2="272" x1="3712" />
        </branch>
        <branch name="out7">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3712" y="336" type="branch" />
            <wire x2="3712" y1="336" y2="336" x1="3168" />
            <wire x2="3840" y1="336" y2="336" x1="3712" />
            <wire x2="3840" y1="320" y2="336" x1="3840" />
        </branch>
        <instance x="2976" y="160" name="XLXI_5" orien="R0" />
        <instance x="2944" y="304" name="XLXI_7" orien="R0" />
        <instance x="2944" y="368" name="XLXI_8" orien="R0" />
        <branch name="out5">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3728" y="208" type="branch" />
            <wire x2="3728" y1="208" y2="208" x1="3184" />
            <wire x2="3840" y1="208" y2="208" x1="3728" />
        </branch>
        <instance x="2960" y="240" name="XLXI_6" orien="R0" />
        <branch name="B(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2960" y="128" type="branch" />
            <wire x2="2960" y1="128" y2="128" x1="2944" />
            <wire x2="2976" y1="128" y2="128" x1="2960" />
        </branch>
        <branch name="B(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2928" y="208" type="branch" />
            <wire x2="2928" y1="208" y2="208" x1="2896" />
            <wire x2="2960" y1="208" y2="208" x1="2928" />
        </branch>
        <branch name="B(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2912" y="272" type="branch" />
            <wire x2="2912" y1="272" y2="272" x1="2880" />
            <wire x2="2944" y1="272" y2="272" x1="2912" />
        </branch>
        <branch name="B(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2912" y="336" type="branch" />
            <wire x2="2912" y1="336" y2="336" x1="2880" />
            <wire x2="2944" y1="336" y2="336" x1="2912" />
        </branch>
        <iomarker fontsize="28" x="3840" y="128" name="out4" orien="R0" />
        <iomarker fontsize="28" x="3840" y="208" name="out5" orien="R0" />
        <iomarker fontsize="28" x="3840" y="272" name="out6" orien="R0" />
        <iomarker fontsize="28" x="3840" y="320" name="out7" orien="R270" />
        <branch name="A(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2480" y="672" type="branch" />
            <wire x2="2480" y1="672" y2="672" x1="2432" />
            <wire x2="2592" y1="672" y2="672" x1="2480" />
        </branch>
        <branch name="A(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2480" y="736" type="branch" />
            <wire x2="2480" y1="736" y2="736" x1="2448" />
            <wire x2="2592" y1="736" y2="736" x1="2480" />
        </branch>
        <branch name="A(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2496" y="800" type="branch" />
            <wire x2="2496" y1="800" y2="800" x1="2448" />
            <wire x2="2592" y1="800" y2="800" x1="2496" />
        </branch>
        <branch name="A(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2480" y="864" type="branch" />
            <wire x2="2480" y1="864" y2="864" x1="2448" />
            <wire x2="2592" y1="864" y2="864" x1="2480" />
        </branch>
        <branch name="B(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2480" y="928" type="branch" />
            <wire x2="2480" y1="928" y2="928" x1="2448" />
            <wire x2="2592" y1="928" y2="928" x1="2480" />
        </branch>
        <branch name="B(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2480" y="992" type="branch" />
            <wire x2="2480" y1="992" y2="992" x1="2448" />
            <wire x2="2592" y1="992" y2="992" x1="2480" />
        </branch>
        <branch name="B(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2496" y="1056" type="branch" />
            <wire x2="2496" y1="1056" y2="1056" x1="2448" />
            <wire x2="2592" y1="1056" y2="1056" x1="2496" />
        </branch>
        <branch name="B(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2480" y="1120" type="branch" />
            <wire x2="2480" y1="1120" y2="1120" x1="2448" />
            <wire x2="2592" y1="1120" y2="1120" x1="2480" />
        </branch>
        <instance x="2592" y="1248" name="XLXI_13" orien="R0" />
        <branch name="n">
            <wire x2="3168" y1="864" y2="864" x1="2976" />
            <wire x2="4064" y1="864" y2="864" x1="3168" />
            <wire x2="3168" y1="624" y2="656" x1="3168" />
            <wire x2="3168" y1="656" y2="864" x1="3168" />
            <wire x2="4064" y1="848" y2="864" x1="4064" />
            <wire x2="4096" y1="848" y2="848" x1="4064" />
            <wire x2="4096" y1="848" y2="864" x1="4096" />
            <wire x2="4128" y1="864" y2="864" x1="4096" />
        </branch>
        <branch name="k">
            <wire x2="3168" y1="928" y2="928" x1="2976" />
            <wire x2="3184" y1="928" y2="928" x1="3168" />
            <wire x2="3184" y1="928" y2="1088" x1="3184" />
            <wire x2="3184" y1="1088" y2="1104" x1="3184" />
            <wire x2="4080" y1="928" y2="928" x1="3184" />
            <wire x2="4128" y1="928" y2="928" x1="4080" />
        </branch>
        <instance x="3168" y="656" name="XLXI_16" orien="R0" />
        <instance x="3184" y="1136" name="XLXI_17" orien="R0" />
        <branch name="XLXN_45">
            <wire x2="3472" y1="624" y2="624" x1="3392" />
        </branch>
        <branch name="XLXN_46">
            <wire x2="3504" y1="1104" y2="1104" x1="3408" />
        </branch>
        <instance x="3472" y="656" name="XLXI_18" orien="R0" />
        <instance x="3504" y="1136" name="XLXI_19" orien="R0" />
        <branch name="n">
            <wire x2="3776" y1="624" y2="624" x1="3696" />
        </branch>
        <branch name="k">
            <wire x2="3856" y1="1104" y2="1104" x1="3728" />
        </branch>
        <iomarker fontsize="28" x="3776" y="624" name="n" orien="R0" />
        <iomarker fontsize="28" x="3856" y="1104" name="k" orien="R0" />
        <instance x="4128" y="992" name="XLXI_20" orien="R0" />
        <branch name="XLXN_50">
            <wire x2="4448" y1="896" y2="896" x1="4384" />
        </branch>
        <instance x="4448" y="928" name="XLXI_21" orien="R0" />
        <branch name="XLXN_51">
            <wire x2="4704" y1="896" y2="896" x1="4672" />
        </branch>
        <instance x="4704" y="928" name="XLXI_22" orien="R0" />
        <branch name="e">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="4960" y="896" type="branch" />
            <wire x2="4960" y1="896" y2="896" x1="4928" />
            <wire x2="5008" y1="896" y2="896" x1="4960" />
        </branch>
        <iomarker fontsize="28" x="5008" y="896" name="e" orien="R0" />
        <branch name="an(3)">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2640" y="1568" type="branch" />
            <wire x2="2640" y1="1344" y2="1568" x1="2640" />
            <wire x2="2640" y1="1568" y2="1616" x1="2640" />
        </branch>
        <branch name="an(2)">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2848" y="1584" type="branch" />
            <wire x2="2848" y1="1360" y2="1584" x1="2848" />
            <wire x2="2848" y1="1584" y2="1632" x1="2848" />
        </branch>
        <branch name="an(1)">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3056" y="1600" type="branch" />
            <wire x2="3056" y1="1376" y2="1600" x1="3056" />
            <wire x2="3056" y1="1600" y2="1648" x1="3056" />
        </branch>
        <branch name="an(0)">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3216" y="1408" type="branch" />
            <wire x2="3216" y1="1392" y2="1408" x1="3216" />
            <wire x2="3216" y1="1408" y2="1664" x1="3216" />
        </branch>
        <instance x="2576" y="1344" name="XLXI_23" orien="R0" />
        <instance x="2784" y="1360" name="XLXI_24" orien="R0" />
        <instance x="2992" y="1376" name="XLXI_25" orien="R0" />
        <instance x="3152" y="1792" name="XLXI_26" orien="R0" />
        <iomarker fontsize="28" x="2640" y="1616" name="an(3)" orien="R90" />
        <iomarker fontsize="28" x="2848" y="1632" name="an(2)" orien="R90" />
        <iomarker fontsize="28" x="3056" y="1648" name="an(1)" orien="R90" />
        <iomarker fontsize="28" x="3216" y="1392" name="an(0)" orien="R270" />
    </sheet>
</drawing>