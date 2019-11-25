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
        <signal name="st" />
        <signal name="XLXN_16" />
        <signal name="B(0)" />
        <signal name="B(1)" />
        <signal name="B(2)" />
        <signal name="B(3)" />
        <signal name="XLXN_26" />
        <signal name="XLXN_27" />
        <signal name="XLXN_28" />
        <signal name="out(0)" />
        <signal name="out(3:0)" />
        <signal name="out(1)" />
        <signal name="out(2)" />
        <signal name="out(3)" />
        <signal name="seg(6:0)" />
        <signal name="out3" />
        <signal name="out2" />
        <signal name="out0" />
        <signal name="out1" />
        <signal name="out4" />
        <signal name="out5" />
        <signal name="out6" />
        <signal name="out7" />
        <signal name="an(0)" />
        <signal name="an(1)" />
        <signal name="an(2)" />
        <signal name="an(3)" />
        <port polarity="Input" name="A(3:0)" />
        <port polarity="Input" name="B(3:0)" />
        <port polarity="Input" name="st" />
        <port polarity="Output" name="seg(6:0)" />
        <port polarity="Output" name="out3" />
        <port polarity="Output" name="out2" />
        <port polarity="Output" name="out0" />
        <port polarity="Output" name="out1" />
        <port polarity="Output" name="out4" />
        <port polarity="Output" name="out5" />
        <port polarity="Output" name="out6" />
        <port polarity="Output" name="out7" />
        <port polarity="Output" name="an(0)" />
        <port polarity="Output" name="an(1)" />
        <port polarity="Output" name="an(2)" />
        <port polarity="Output" name="an(3)" />
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
        <blockdef name="xor2">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-64" y2="-64" x1="0" />
            <line x2="60" y1="-128" y2="-128" x1="0" />
            <line x2="208" y1="-96" y2="-96" x1="256" />
            <arc ex="44" ey="-144" sx="48" sy="-48" r="56" cx="16" cy="-96" />
            <arc ex="64" ey="-144" sx="64" sy="-48" r="56" cx="32" cy="-96" />
            <line x2="64" y1="-144" y2="-144" x1="128" />
            <line x2="64" y1="-48" y2="-48" x1="128" />
            <arc ex="128" ey="-144" sx="208" sy="-96" r="88" cx="132" cy="-56" />
            <arc ex="208" ey="-96" sx="128" sy="-48" r="88" cx="132" cy="-136" />
        </blockdef>
        <blockdef name="hex_7seg">
            <timestamp>2019-11-21T12:55:54</timestamp>
            <rect width="256" x="64" y="-64" height="64" />
            <rect width="64" x="0" y="-44" height="24" />
            <line x2="0" y1="-32" y2="-32" x1="64" />
            <rect width="64" x="320" y="-44" height="24" />
            <line x2="384" y1="-32" y2="-32" x1="320" />
        </blockdef>
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
        <blockdef name="vcc">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="64" y1="-32" y2="-64" x1="64" />
            <line x2="64" y1="0" y2="-32" x1="64" />
            <line x2="32" y1="-64" y2="-64" x1="96" />
        </blockdef>
        <block symbolname="add4" name="XLXI_1">
            <blockpin signalname="A(0)" name="A0" />
            <blockpin signalname="A(1)" name="A1" />
            <blockpin signalname="A(2)" name="A2" />
            <blockpin signalname="A(3)" name="A3" />
            <blockpin signalname="XLXN_16" name="B0" />
            <blockpin signalname="XLXN_26" name="B1" />
            <blockpin signalname="XLXN_27" name="B2" />
            <blockpin signalname="XLXN_28" name="B3" />
            <blockpin signalname="st" name="CI" />
            <blockpin name="CO" />
            <blockpin name="OFL" />
            <blockpin signalname="out(0)" name="S0" />
            <blockpin signalname="out(1)" name="S1" />
            <blockpin signalname="out(2)" name="S2" />
            <blockpin signalname="out(3)" name="S3" />
        </block>
        <block symbolname="xor2" name="XLXI_2">
            <blockpin signalname="B(0)" name="I0" />
            <blockpin signalname="st" name="I1" />
            <blockpin signalname="XLXN_16" name="O" />
        </block>
        <block symbolname="xor2" name="XLXI_3">
            <blockpin signalname="B(1)" name="I0" />
            <blockpin signalname="st" name="I1" />
            <blockpin signalname="XLXN_26" name="O" />
        </block>
        <block symbolname="xor2" name="XLXI_4">
            <blockpin signalname="B(2)" name="I0" />
            <blockpin signalname="st" name="I1" />
            <blockpin signalname="XLXN_27" name="O" />
        </block>
        <block symbolname="xor2" name="XLXI_5">
            <blockpin signalname="B(3)" name="I0" />
            <blockpin signalname="st" name="I1" />
            <blockpin signalname="XLXN_28" name="O" />
        </block>
        <block symbolname="hex_7seg" name="XLXI_6">
            <blockpin signalname="out(3:0)" name="d(3:0)" />
            <blockpin signalname="seg(6:0)" name="s(6:0)" />
        </block>
        <block symbolname="buf" name="XLXI_7">
            <blockpin signalname="A(1)" name="I" />
            <blockpin signalname="out1" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_8">
            <blockpin signalname="A(2)" name="I" />
            <blockpin signalname="out2" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_9">
            <blockpin signalname="A(0)" name="I" />
            <blockpin signalname="out0" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_10">
            <blockpin signalname="A(3)" name="I" />
            <blockpin signalname="out3" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_11">
            <blockpin signalname="B(0)" name="I" />
            <blockpin signalname="out4" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_12">
            <blockpin signalname="B(1)" name="I" />
            <blockpin signalname="out5" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_13">
            <blockpin signalname="B(2)" name="I" />
            <blockpin signalname="out6" name="O" />
        </block>
        <block symbolname="buf" name="XLXI_14">
            <blockpin signalname="B(3)" name="I" />
            <blockpin signalname="out7" name="O" />
        </block>
        <block symbolname="gnd" name="XLXI_16">
            <blockpin signalname="an(0)" name="G" />
        </block>
        <block symbolname="vcc" name="XLXI_17">
            <blockpin signalname="an(1)" name="P" />
        </block>
        <block symbolname="vcc" name="XLXI_18">
            <blockpin signalname="an(2)" name="P" />
        </block>
        <block symbolname="vcc" name="XLXI_19">
            <blockpin signalname="an(3)" name="P" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="7040" height="5440">
        <branch name="A(3:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="528" y="528" type="branch" />
            <wire x2="528" y1="528" y2="528" x1="416" />
            <wire x2="1600" y1="528" y2="528" x1="528" />
            <wire x2="1600" y1="528" y2="608" x1="1600" />
            <wire x2="1600" y1="608" y2="656" x1="1600" />
            <wire x2="1600" y1="656" y2="704" x1="1600" />
            <wire x2="1600" y1="704" y2="752" x1="1600" />
            <wire x2="1600" y1="752" y2="864" x1="1600" />
        </branch>
        <branch name="B(3:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="912" y="1472" type="branch" />
            <wire x2="912" y1="1472" y2="1472" x1="384" />
            <wire x2="1584" y1="1472" y2="1472" x1="912" />
            <wire x2="1584" y1="1072" y2="1104" x1="1584" />
            <wire x2="1584" y1="1104" y2="1152" x1="1584" />
            <wire x2="1584" y1="1152" y2="1200" x1="1584" />
            <wire x2="1584" y1="1200" y2="1248" x1="1584" />
            <wire x2="1584" y1="1248" y2="1472" x1="1584" />
        </branch>
        <bustap x2="1696" y1="608" y2="608" x1="1600" />
        <bustap x2="1696" y1="656" y2="656" x1="1600" />
        <bustap x2="1696" y1="704" y2="704" x1="1600" />
        <bustap x2="1696" y1="752" y2="752" x1="1600" />
        <branch name="A(0)">
            <attrtext style="alignment:SOFT-TCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1776" y="608" type="branch" />
            <wire x2="1776" y1="608" y2="608" x1="1696" />
            <wire x2="1776" y1="592" y2="608" x1="1776" />
            <wire x2="2112" y1="592" y2="592" x1="1776" />
            <wire x2="2384" y1="592" y2="592" x1="2112" />
            <wire x2="2112" y1="592" y2="624" x1="2112" />
            <wire x2="2112" y1="528" y2="528" x1="2048" />
            <wire x2="2048" y1="528" y2="624" x1="2048" />
            <wire x2="2112" y1="624" y2="624" x1="2048" />
        </branch>
        <branch name="A(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1776" y="656" type="branch" />
            <wire x2="1776" y1="656" y2="656" x1="1696" />
            <wire x2="1952" y1="656" y2="656" x1="1776" />
            <wire x2="2384" y1="656" y2="656" x1="1952" />
            <wire x2="2112" y1="448" y2="448" x1="1952" />
            <wire x2="1952" y1="448" y2="656" x1="1952" />
        </branch>
        <branch name="A(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1776" y="704" type="branch" />
            <wire x2="1776" y1="704" y2="704" x1="1696" />
            <wire x2="1776" y1="704" y2="720" x1="1776" />
            <wire x2="1952" y1="720" y2="720" x1="1776" />
            <wire x2="2384" y1="720" y2="720" x1="1952" />
            <wire x2="1952" y1="720" y2="736" x1="1952" />
            <wire x2="2000" y1="736" y2="736" x1="1952" />
            <wire x2="2000" y1="368" y2="736" x1="2000" />
            <wire x2="2112" y1="368" y2="368" x1="2000" />
        </branch>
        <branch name="A(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1760" y="752" type="branch" />
            <wire x2="1760" y1="752" y2="752" x1="1696" />
            <wire x2="1760" y1="752" y2="784" x1="1760" />
            <wire x2="2016" y1="784" y2="784" x1="1760" />
            <wire x2="2384" y1="784" y2="784" x1="2016" />
            <wire x2="2112" y1="272" y2="272" x1="2016" />
            <wire x2="2016" y1="272" y2="784" x1="2016" />
        </branch>
        <bustap x2="1680" y1="1104" y2="1104" x1="1584" />
        <bustap x2="1680" y1="1152" y2="1152" x1="1584" />
        <bustap x2="1680" y1="1200" y2="1200" x1="1584" />
        <bustap x2="1680" y1="1248" y2="1248" x1="1584" />
        <branch name="st">
            <wire x2="1920" y1="320" y2="320" x1="1312" />
            <wire x2="1920" y1="320" y2="928" x1="1920" />
            <wire x2="2000" y1="928" y2="928" x1="1920" />
            <wire x2="1920" y1="928" y2="1040" x1="1920" />
            <wire x2="2016" y1="1040" y2="1040" x1="1920" />
            <wire x2="1920" y1="1040" y2="1152" x1="1920" />
            <wire x2="2016" y1="1152" y2="1152" x1="1920" />
            <wire x2="1920" y1="1152" y2="1280" x1="1920" />
            <wire x2="2016" y1="1280" y2="1280" x1="1920" />
            <wire x2="1920" y1="1280" y2="1472" x1="1920" />
            <wire x2="2384" y1="320" y2="320" x1="1920" />
            <wire x2="2384" y1="320" y2="464" x1="2384" />
        </branch>
        <iomarker fontsize="28" x="1312" y="320" name="st" orien="R180" />
        <instance x="2000" y="1056" name="XLXI_2" orien="R0" />
        <instance x="2016" y="1168" name="XLXI_3" orien="R0" />
        <instance x="2016" y="1280" name="XLXI_4" orien="R0" />
        <instance x="2016" y="1408" name="XLXI_5" orien="R0" />
        <branch name="B(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1776" y="1104" type="branch" />
            <wire x2="1776" y1="1104" y2="1104" x1="1680" />
            <wire x2="1840" y1="1104" y2="1104" x1="1776" />
            <wire x2="1840" y1="1104" y2="1184" x1="1840" />
            <wire x2="1968" y1="1184" y2="1184" x1="1840" />
            <wire x2="1968" y1="1184" y2="1568" x1="1968" />
            <wire x2="2320" y1="1568" y2="1568" x1="1968" />
            <wire x2="1840" y1="992" y2="1104" x1="1840" />
            <wire x2="2000" y1="992" y2="992" x1="1840" />
        </branch>
        <branch name="B(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1776" y="1152" type="branch" />
            <wire x2="1776" y1="1152" y2="1152" x1="1680" />
            <wire x2="1824" y1="1152" y2="1152" x1="1776" />
            <wire x2="1856" y1="1152" y2="1152" x1="1824" />
            <wire x2="1824" y1="1152" y2="1632" x1="1824" />
            <wire x2="1968" y1="1632" y2="1632" x1="1824" />
            <wire x2="2336" y1="1632" y2="1632" x1="1968" />
            <wire x2="1856" y1="1104" y2="1152" x1="1856" />
            <wire x2="2016" y1="1104" y2="1104" x1="1856" />
        </branch>
        <branch name="B(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1776" y="1200" type="branch" />
            <wire x2="1776" y1="1200" y2="1200" x1="1680" />
            <wire x2="1808" y1="1200" y2="1200" x1="1776" />
            <wire x2="1840" y1="1200" y2="1200" x1="1808" />
            <wire x2="1840" y1="1200" y2="1216" x1="1840" />
            <wire x2="2016" y1="1216" y2="1216" x1="1840" />
            <wire x2="1808" y1="1200" y2="1696" x1="1808" />
            <wire x2="1968" y1="1696" y2="1696" x1="1808" />
            <wire x2="2304" y1="1696" y2="1696" x1="1968" />
        </branch>
        <branch name="B(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="1776" y="1248" type="branch" />
            <wire x2="1760" y1="1248" y2="1248" x1="1680" />
            <wire x2="1776" y1="1248" y2="1248" x1="1760" />
            <wire x2="1840" y1="1248" y2="1248" x1="1776" />
            <wire x2="1840" y1="1248" y2="1344" x1="1840" />
            <wire x2="2016" y1="1344" y2="1344" x1="1840" />
            <wire x2="1760" y1="1248" y2="1792" x1="1760" />
            <wire x2="1952" y1="1792" y2="1792" x1="1760" />
            <wire x2="2304" y1="1792" y2="1792" x1="1952" />
        </branch>
        <instance x="2384" y="1296" name="XLXI_1" orien="R0" />
        <branch name="XLXN_16">
            <wire x2="2272" y1="960" y2="960" x1="2256" />
            <wire x2="2384" y1="912" y2="912" x1="2272" />
            <wire x2="2272" y1="912" y2="960" x1="2272" />
        </branch>
        <branch name="XLXN_26">
            <wire x2="2320" y1="1072" y2="1072" x1="2272" />
            <wire x2="2320" y1="976" y2="1072" x1="2320" />
            <wire x2="2384" y1="976" y2="976" x1="2320" />
        </branch>
        <branch name="XLXN_27">
            <wire x2="2336" y1="1184" y2="1184" x1="2272" />
            <wire x2="2336" y1="1040" y2="1184" x1="2336" />
            <wire x2="2384" y1="1040" y2="1040" x1="2336" />
        </branch>
        <branch name="XLXN_28">
            <wire x2="2352" y1="1312" y2="1312" x1="2272" />
            <wire x2="2352" y1="1104" y2="1312" x1="2352" />
            <wire x2="2384" y1="1104" y2="1104" x1="2352" />
        </branch>
        <branch name="out(0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3024" y="752" type="branch" />
            <wire x2="3024" y1="752" y2="752" x1="2832" />
            <wire x2="3056" y1="752" y2="752" x1="3024" />
            <wire x2="3200" y1="752" y2="752" x1="3056" />
        </branch>
        <branch name="out(3:0)">
            <attrtext style="alignment:SOFT-TVCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3296" y="800" type="branch" />
            <wire x2="3472" y1="624" y2="624" x1="3296" />
            <wire x2="3296" y1="624" y2="704" x1="3296" />
            <wire x2="3296" y1="704" y2="752" x1="3296" />
            <wire x2="3296" y1="752" y2="800" x1="3296" />
            <wire x2="3296" y1="800" y2="864" x1="3296" />
            <wire x2="3296" y1="864" y2="912" x1="3296" />
            <wire x2="3296" y1="912" y2="960" x1="3296" />
            <wire x2="3296" y1="960" y2="1024" x1="3296" />
        </branch>
        <bustap x2="3200" y1="752" y2="752" x1="3296" />
        <bustap x2="3200" y1="864" y2="864" x1="3296" />
        <bustap x2="3200" y1="912" y2="912" x1="3296" />
        <bustap x2="3200" y1="960" y2="960" x1="3296" />
        <branch name="out(1)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2992" y="816" type="branch" />
            <wire x2="2992" y1="816" y2="816" x1="2832" />
            <wire x2="3056" y1="816" y2="816" x1="2992" />
            <wire x2="3056" y1="816" y2="864" x1="3056" />
            <wire x2="3200" y1="864" y2="864" x1="3056" />
        </branch>
        <branch name="out(2)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2992" y="880" type="branch" />
            <wire x2="2992" y1="880" y2="880" x1="2832" />
            <wire x2="3056" y1="880" y2="880" x1="2992" />
            <wire x2="3056" y1="880" y2="912" x1="3056" />
            <wire x2="3200" y1="912" y2="912" x1="3056" />
        </branch>
        <branch name="out(3)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2992" y="944" type="branch" />
            <wire x2="2992" y1="944" y2="944" x1="2832" />
            <wire x2="3072" y1="944" y2="944" x1="2992" />
            <wire x2="3072" y1="944" y2="960" x1="3072" />
            <wire x2="3200" y1="960" y2="960" x1="3072" />
        </branch>
        <instance x="3472" y="656" name="XLXI_6" orien="R0">
        </instance>
        <branch name="seg(6:0)">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="4000" y="624" type="branch" />
            <wire x2="4000" y1="624" y2="624" x1="3856" />
            <wire x2="4096" y1="624" y2="624" x1="4000" />
        </branch>
        <iomarker fontsize="28" x="4096" y="624" name="seg(6:0)" orien="R0" />
        <instance x="2112" y="480" name="XLXI_7" orien="R0" />
        <instance x="2112" y="400" name="XLXI_8" orien="R0" />
        <instance x="2112" y="560" name="XLXI_9" orien="R0" />
        <instance x="2112" y="304" name="XLXI_10" orien="R0" />
        <branch name="out3">
            <wire x2="2528" y1="272" y2="272" x1="2336" />
        </branch>
        <branch name="out2">
            <wire x2="2512" y1="368" y2="368" x1="2336" />
            <wire x2="2512" y1="352" y2="368" x1="2512" />
        </branch>
        <branch name="out0">
            <wire x2="2368" y1="528" y2="528" x1="2336" />
            <wire x2="2368" y1="336" y2="528" x1="2368" />
            <wire x2="2656" y1="336" y2="336" x1="2368" />
        </branch>
        <iomarker fontsize="28" x="2528" y="272" name="out3" orien="R0" />
        <iomarker fontsize="28" x="2656" y="336" name="out0" orien="R0" />
        <iomarker fontsize="28" x="2512" y="352" name="out2" orien="R270" />
        <branch name="out1">
            <wire x2="2512" y1="448" y2="448" x1="2336" />
            <wire x2="2512" y1="432" y2="448" x1="2512" />
            <wire x2="2880" y1="432" y2="432" x1="2512" />
            <wire x2="2880" y1="416" y2="432" x1="2880" />
            <wire x2="2912" y1="416" y2="416" x1="2880" />
        </branch>
        <iomarker fontsize="28" x="2912" y="416" name="out1" orien="R0" />
        <instance x="2320" y="1600" name="XLXI_11" orien="R0" />
        <instance x="2336" y="1664" name="XLXI_12" orien="R0" />
        <instance x="2304" y="1728" name="XLXI_13" orien="R0" />
        <instance x="2304" y="1824" name="XLXI_14" orien="R0" />
        <branch name="out4">
            <wire x2="2576" y1="1568" y2="1568" x1="2544" />
        </branch>
        <iomarker fontsize="28" x="2576" y="1568" name="out4" orien="R0" />
        <branch name="out5">
            <wire x2="2592" y1="1632" y2="1632" x1="2560" />
        </branch>
        <iomarker fontsize="28" x="2592" y="1632" name="out5" orien="R0" />
        <branch name="out6">
            <wire x2="2560" y1="1696" y2="1696" x1="2528" />
        </branch>
        <iomarker fontsize="28" x="2560" y="1696" name="out6" orien="R0" />
        <branch name="out7">
            <wire x2="2560" y1="1792" y2="1792" x1="2528" />
        </branch>
        <iomarker fontsize="28" x="2560" y="1792" name="out7" orien="R0" />
        <branch name="an(0)">
            <wire x2="3712" y1="912" y2="1328" x1="3712" />
            <wire x2="3712" y1="1328" y2="1344" x1="3712" />
        </branch>
        <branch name="an(1)">
            <wire x2="3968" y1="896" y2="1344" x1="3968" />
        </branch>
        <branch name="an(2)">
            <wire x2="4112" y1="880" y2="880" x1="4096" />
            <wire x2="4112" y1="880" y2="1360" x1="4112" />
        </branch>
        <branch name="an(3)">
            <wire x2="4240" y1="880" y2="1376" x1="4240" />
        </branch>
        <iomarker fontsize="28" x="3712" y="912" name="an(0)" orien="R270" />
        <iomarker fontsize="28" x="3968" y="896" name="an(1)" orien="R270" />
        <iomarker fontsize="28" x="4096" y="880" name="an(2)" orien="R180" />
        <iomarker fontsize="28" x="4240" y="880" name="an(3)" orien="R270" />
        <instance x="3648" y="1472" name="XLXI_16" orien="R0" />
        <instance x="4032" y="1344" name="XLXI_17" orien="R180" />
        <instance x="4176" y="1360" name="XLXI_18" orien="R180" />
        <instance x="4304" y="1376" name="XLXI_19" orien="R180" />
        <iomarker fontsize="28" x="416" y="528" name="A(3:0)" orien="R180" />
        <iomarker fontsize="28" x="384" y="1472" name="B(3:0)" orien="R180" />
    </sheet>
</drawing>