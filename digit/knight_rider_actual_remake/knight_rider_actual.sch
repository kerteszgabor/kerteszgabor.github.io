<?xml version="1.0" encoding="UTF-8"?>
<drawing version="7">
    <attr value="spartan3e" name="DeviceFamilyName">
        <trait delete="all:0" />
        <trait editname="all:0" />
        <trait edittrait="all:0" />
    </attr>
    <netlist>
        <signal name="XLXN_6" />
        <signal name="led0" />
        <signal name="led1" />
        <signal name="led2" />
        <signal name="led3" />
        <signal name="led4" />
        <signal name="led5" />
        <signal name="led6" />
        <signal name="led7" />
        <signal name="q0" />
        <signal name="q1" />
        <signal name="q2" />
        <signal name="sw" />
        <signal name="XLXN_43" />
        <signal name="XLXN_44" />
        <signal name="XLXN_45" />
        <signal name="clk" />
        <signal name="XLXN_48" />
        <signal name="irany" />
        <signal name="XLXN_50" />
        <signal name="XLXN_51" />
        <signal name="XLXN_53" />
        <signal name="XLXN_54" />
        <signal name="XLXN_55" />
        <signal name="XLXN_56" />
        <signal name="XLXN_57" />
        <signal name="XLXN_58" />
        <port polarity="Output" name="led0" />
        <port polarity="Output" name="led1" />
        <port polarity="Output" name="led2" />
        <port polarity="Output" name="led3" />
        <port polarity="Output" name="led4" />
        <port polarity="Output" name="led5" />
        <port polarity="Output" name="led6" />
        <port polarity="Output" name="led7" />
        <port polarity="Input" name="sw" />
        <port polarity="Input" name="clk" />
        <port polarity="Input" name="irany" />
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
        <blockdef name="and3b3">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="40" y1="-64" y2="-64" x1="0" />
            <circle r="12" cx="52" cy="-64" />
            <line x2="40" y1="-128" y2="-128" x1="0" />
            <circle r="12" cx="52" cy="-128" />
            <line x2="40" y1="-192" y2="-192" x1="0" />
            <circle r="12" cx="52" cy="-192" />
            <line x2="192" y1="-128" y2="-128" x1="256" />
            <line x2="144" y1="-176" y2="-176" x1="64" />
            <line x2="64" y1="-64" y2="-192" x1="64" />
            <arc ex="144" ey="-176" sx="144" sy="-80" r="48" cx="144" cy="-128" />
            <line x2="64" y1="-80" y2="-80" x1="144" />
        </blockdef>
        <blockdef name="and3b2">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="40" y1="-64" y2="-64" x1="0" />
            <circle r="12" cx="52" cy="-64" />
            <line x2="40" y1="-128" y2="-128" x1="0" />
            <circle r="12" cx="52" cy="-128" />
            <line x2="64" y1="-192" y2="-192" x1="0" />
            <line x2="192" y1="-128" y2="-128" x1="256" />
            <line x2="64" y1="-64" y2="-192" x1="64" />
            <arc ex="144" ey="-176" sx="144" sy="-80" r="48" cx="144" cy="-128" />
            <line x2="64" y1="-80" y2="-80" x1="144" />
            <line x2="144" y1="-176" y2="-176" x1="64" />
        </blockdef>
        <blockdef name="and3b1">
            <timestamp>2000-1-1T10:10:10</timestamp>
            <line x2="40" y1="-64" y2="-64" x1="0" />
            <circle r="12" cx="52" cy="-64" />
            <line x2="64" y1="-128" y2="-128" x1="0" />
            <line x2="64" y1="-192" y2="-192" x1="0" />
            <line x2="192" y1="-128" y2="-128" x1="256" />
            <line x2="64" y1="-64" y2="-192" x1="64" />
            <arc ex="144" ey="-176" sx="144" sy="-80" r="48" cx="144" cy="-128" />
            <line x2="64" y1="-80" y2="-80" x1="144" />
            <line x2="144" y1="-176" y2="-176" x1="64" />
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
        <block symbolname="cb4ce" name="XLXI_1">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="XLXN_43" name="CE" />
            <blockpin signalname="XLXN_6" name="CLR" />
            <blockpin name="CEO" />
            <blockpin signalname="XLXN_56" name="Q0" />
            <blockpin signalname="XLXN_57" name="Q1" />
            <blockpin signalname="XLXN_58" name="Q2" />
            <blockpin signalname="XLXN_6" name="Q3" />
            <blockpin name="TC" />
        </block>
        <block symbolname="and3b3" name="XLXI_2">
            <blockpin signalname="q2" name="I0" />
            <blockpin signalname="q1" name="I1" />
            <blockpin signalname="q0" name="I2" />
            <blockpin signalname="led0" name="O" />
        </block>
        <block symbolname="and3b2" name="XLXI_3">
            <blockpin signalname="q2" name="I0" />
            <blockpin signalname="q1" name="I1" />
            <blockpin signalname="q0" name="I2" />
            <blockpin signalname="led1" name="O" />
        </block>
        <block symbolname="and3b2" name="XLXI_4">
            <blockpin signalname="q2" name="I0" />
            <blockpin signalname="q0" name="I1" />
            <blockpin signalname="q1" name="I2" />
            <blockpin signalname="led2" name="O" />
        </block>
        <block symbolname="and3b1" name="XLXI_5">
            <blockpin signalname="q2" name="I0" />
            <blockpin signalname="q1" name="I1" />
            <blockpin signalname="q0" name="I2" />
            <blockpin signalname="led3" name="O" />
        </block>
        <block symbolname="and3b2" name="XLXI_6">
            <blockpin signalname="q1" name="I0" />
            <blockpin signalname="q0" name="I1" />
            <blockpin signalname="q2" name="I2" />
            <blockpin signalname="led4" name="O" />
        </block>
        <block symbolname="and3b1" name="XLXI_7">
            <blockpin signalname="q1" name="I0" />
            <blockpin signalname="q2" name="I1" />
            <blockpin signalname="q0" name="I2" />
            <blockpin signalname="led5" name="O" />
        </block>
        <block symbolname="and3b1" name="XLXI_8">
            <blockpin signalname="q0" name="I0" />
            <blockpin signalname="q1" name="I1" />
            <blockpin signalname="q2" name="I2" />
            <blockpin signalname="led6" name="O" />
        </block>
        <block symbolname="and3" name="XLXI_9">
            <blockpin signalname="q2" name="I0" />
            <blockpin signalname="q1" name="I1" />
            <blockpin signalname="q0" name="I2" />
            <blockpin signalname="led7" name="O" />
        </block>
        <block symbolname="cb16ce" name="XLXI_10">
            <blockpin signalname="clk" name="C" />
            <blockpin signalname="sw" name="CE" />
            <blockpin signalname="XLXN_45" name="CLR" />
            <blockpin signalname="XLXN_43" name="CEO" />
            <blockpin name="Q(15:0)" />
            <blockpin name="TC" />
        </block>
        <block symbolname="gnd" name="XLXI_12">
            <blockpin signalname="XLXN_45" name="G" />
        </block>
        <block symbolname="xor2" name="XLXI_14">
            <blockpin signalname="XLXN_56" name="I0" />
            <blockpin signalname="irany" name="I1" />
            <blockpin signalname="q0" name="O" />
        </block>
        <block symbolname="xor2" name="XLXI_15">
            <blockpin signalname="XLXN_57" name="I0" />
            <blockpin signalname="irany" name="I1" />
            <blockpin signalname="q1" name="O" />
        </block>
        <block symbolname="xor2" name="XLXI_16">
            <blockpin signalname="XLXN_58" name="I0" />
            <blockpin signalname="irany" name="I1" />
            <blockpin signalname="q2" name="O" />
        </block>
    </netlist>
    <sheet sheetnum="1" width="7040" height="5440">
        <instance x="2336" y="1040" name="XLXI_1" orien="R0" />
        <branch name="XLXN_6">
            <wire x2="2336" y1="1008" y2="1072" x1="2336" />
            <wire x2="2800" y1="1072" y2="1072" x1="2336" />
            <wire x2="2800" y1="784" y2="784" x1="2720" />
            <wire x2="2800" y1="784" y2="1072" x1="2800" />
        </branch>
        <instance x="3072" y="1248" name="XLXI_2" orien="R0" />
        <instance x="3056" y="1536" name="XLXI_3" orien="R0" />
        <instance x="3056" y="1808" name="XLXI_4" orien="R0" />
        <instance x="3056" y="2032" name="XLXI_5" orien="R0" />
        <instance x="3072" y="2272" name="XLXI_6" orien="R0" />
        <instance x="3072" y="2480" name="XLXI_7" orien="R0" />
        <instance x="3072" y="2688" name="XLXI_8" orien="R0" />
        <instance x="3056" y="2912" name="XLXI_9" orien="R0" />
        <branch name="q0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="1056" type="branch" />
            <wire x2="3008" y1="1056" y2="1056" x1="2976" />
            <wire x2="3072" y1="1056" y2="1056" x1="3008" />
        </branch>
        <branch name="q1">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="1120" type="branch" />
            <wire x2="3008" y1="1120" y2="1120" x1="2976" />
            <wire x2="3072" y1="1120" y2="1120" x1="3008" />
        </branch>
        <branch name="q2">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="1184" type="branch" />
            <wire x2="3008" y1="1184" y2="1184" x1="2960" />
            <wire x2="3072" y1="1184" y2="1184" x1="3008" />
        </branch>
        <branch name="q0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="1344" type="branch" />
            <wire x2="3008" y1="1344" y2="1344" x1="2960" />
            <wire x2="3056" y1="1344" y2="1344" x1="3008" />
        </branch>
        <branch name="q1">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="1408" type="branch" />
            <wire x2="3008" y1="1408" y2="1408" x1="2960" />
            <wire x2="3056" y1="1408" y2="1408" x1="3008" />
        </branch>
        <branch name="q2">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="1472" type="branch" />
            <wire x2="3008" y1="1472" y2="1472" x1="2960" />
            <wire x2="3056" y1="1472" y2="1472" x1="3008" />
        </branch>
        <branch name="q1">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3024" y="1616" type="branch" />
            <wire x2="3024" y1="1616" y2="1616" x1="2944" />
            <wire x2="3056" y1="1616" y2="1616" x1="3024" />
        </branch>
        <branch name="q0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="1680" type="branch" />
            <wire x2="3008" y1="1680" y2="1680" x1="2928" />
            <wire x2="3056" y1="1680" y2="1680" x1="3008" />
        </branch>
        <branch name="q2">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="1744" type="branch" />
            <wire x2="3008" y1="1744" y2="1744" x1="2928" />
            <wire x2="3056" y1="1744" y2="1744" x1="3008" />
        </branch>
        <branch name="q0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="1840" type="branch" />
            <wire x2="3008" y1="1840" y2="1840" x1="2928" />
            <wire x2="3056" y1="1840" y2="1840" x1="3008" />
        </branch>
        <branch name="q1">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2992" y="1904" type="branch" />
            <wire x2="2992" y1="1904" y2="1904" x1="2928" />
            <wire x2="3056" y1="1904" y2="1904" x1="2992" />
        </branch>
        <branch name="q2">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="2992" y="1968" type="branch" />
            <wire x2="2992" y1="1968" y2="1968" x1="2928" />
            <wire x2="3056" y1="1968" y2="1968" x1="2992" />
        </branch>
        <branch name="q2">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2080" type="branch" />
            <wire x2="3008" y1="2080" y2="2080" x1="2928" />
            <wire x2="3072" y1="2080" y2="2080" x1="3008" />
        </branch>
        <branch name="q0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2144" type="branch" />
            <wire x2="3008" y1="2144" y2="2144" x1="2928" />
            <wire x2="3072" y1="2144" y2="2144" x1="3008" />
        </branch>
        <branch name="q1">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2208" type="branch" />
            <wire x2="3008" y1="2208" y2="2208" x1="2928" />
            <wire x2="3072" y1="2208" y2="2208" x1="3008" />
        </branch>
        <branch name="q0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2288" type="branch" />
            <wire x2="3008" y1="2288" y2="2288" x1="2928" />
            <wire x2="3072" y1="2288" y2="2288" x1="3008" />
        </branch>
        <branch name="q2">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2352" type="branch" />
            <wire x2="3008" y1="2352" y2="2352" x1="2928" />
            <wire x2="3072" y1="2352" y2="2352" x1="3008" />
        </branch>
        <branch name="q1">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2416" type="branch" />
            <wire x2="3008" y1="2416" y2="2416" x1="2928" />
            <wire x2="3072" y1="2416" y2="2416" x1="3008" />
        </branch>
        <branch name="q2">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2496" type="branch" />
            <wire x2="3008" y1="2496" y2="2496" x1="2928" />
            <wire x2="3072" y1="2496" y2="2496" x1="3008" />
        </branch>
        <branch name="q1">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3024" y="2560" type="branch" />
            <wire x2="3024" y1="2560" y2="2560" x1="2944" />
            <wire x2="3072" y1="2560" y2="2560" x1="3024" />
        </branch>
        <branch name="q0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2624" type="branch" />
            <wire x2="3008" y1="2624" y2="2624" x1="2944" />
            <wire x2="3072" y1="2624" y2="2624" x1="3008" />
        </branch>
        <branch name="q0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2720" type="branch" />
            <wire x2="3008" y1="2720" y2="2720" x1="2944" />
            <wire x2="3056" y1="2720" y2="2720" x1="3008" />
        </branch>
        <branch name="q1">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2784" type="branch" />
            <wire x2="3008" y1="2784" y2="2784" x1="2944" />
            <wire x2="3056" y1="2784" y2="2784" x1="3008" />
        </branch>
        <branch name="q2">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="3008" y="2848" type="branch" />
            <wire x2="3008" y1="2848" y2="2848" x1="2944" />
            <wire x2="3056" y1="2848" y2="2848" x1="3008" />
        </branch>
        <branch name="led0">
            <wire x2="3360" y1="1120" y2="1120" x1="3328" />
        </branch>
        <iomarker fontsize="28" x="3360" y="1120" name="led0" orien="R0" />
        <branch name="led1">
            <wire x2="3344" y1="1408" y2="1408" x1="3312" />
        </branch>
        <iomarker fontsize="28" x="3344" y="1408" name="led1" orien="R0" />
        <branch name="led2">
            <wire x2="3344" y1="1680" y2="1680" x1="3312" />
        </branch>
        <iomarker fontsize="28" x="3344" y="1680" name="led2" orien="R0" />
        <branch name="led3">
            <wire x2="3344" y1="1904" y2="1904" x1="3312" />
        </branch>
        <iomarker fontsize="28" x="3344" y="1904" name="led3" orien="R0" />
        <branch name="led4">
            <wire x2="3360" y1="2144" y2="2144" x1="3328" />
        </branch>
        <iomarker fontsize="28" x="3360" y="2144" name="led4" orien="R0" />
        <branch name="led5">
            <wire x2="3360" y1="2352" y2="2352" x1="3328" />
        </branch>
        <iomarker fontsize="28" x="3360" y="2352" name="led5" orien="R0" />
        <branch name="led6">
            <wire x2="3360" y1="2560" y2="2560" x1="3328" />
        </branch>
        <iomarker fontsize="28" x="3360" y="2560" name="led6" orien="R0" />
        <branch name="led7">
            <wire x2="3344" y1="2784" y2="2784" x1="3312" />
        </branch>
        <iomarker fontsize="28" x="3344" y="2784" name="led7" orien="R0" />
        <instance x="816" y="848" name="XLXI_10" orien="R0" />
        <branch name="sw">
            <wire x2="624" y1="512" y2="656" x1="624" />
            <wire x2="816" y1="656" y2="656" x1="624" />
        </branch>
        <branch name="XLXN_43">
            <wire x2="1408" y1="656" y2="656" x1="1200" />
            <wire x2="1408" y1="384" y2="656" x1="1408" />
            <wire x2="1616" y1="384" y2="384" x1="1408" />
            <wire x2="2000" y1="384" y2="384" x1="1616" />
            <wire x2="2160" y1="384" y2="384" x1="2000" />
            <wire x2="2160" y1="384" y2="848" x1="2160" />
            <wire x2="2336" y1="848" y2="848" x1="2160" />
        </branch>
        <iomarker fontsize="28" x="432" y="720" name="clk" orien="R180" />
        <iomarker fontsize="28" x="624" y="512" name="sw" orien="R270" />
        <branch name="XLXN_45">
            <wire x2="816" y1="816" y2="928" x1="816" />
        </branch>
        <instance x="752" y="1056" name="XLXI_12" orien="R0" />
        <branch name="clk">
            <wire x2="640" y1="720" y2="720" x1="432" />
            <wire x2="816" y1="720" y2="720" x1="640" />
            <wire x2="640" y1="720" y2="912" x1="640" />
            <wire x2="2336" y1="912" y2="912" x1="640" />
        </branch>
        <iomarker fontsize="28" x="3216" y="304" name="irany" orien="R180" />
        <instance x="3776" y="624" name="XLXI_14" orien="R0" />
        <instance x="3776" y="784" name="XLXI_15" orien="R0" />
        <instance x="3776" y="928" name="XLXI_16" orien="R0" />
        <branch name="irany">
            <wire x2="3712" y1="304" y2="304" x1="3216" />
            <wire x2="3712" y1="304" y2="496" x1="3712" />
            <wire x2="3776" y1="496" y2="496" x1="3712" />
            <wire x2="3712" y1="496" y2="656" x1="3712" />
            <wire x2="3776" y1="656" y2="656" x1="3712" />
            <wire x2="3712" y1="656" y2="800" x1="3712" />
            <wire x2="3776" y1="800" y2="800" x1="3712" />
        </branch>
        <branch name="XLXN_56">
            <wire x2="3248" y1="592" y2="592" x1="2720" />
            <wire x2="3248" y1="560" y2="592" x1="3248" />
            <wire x2="3776" y1="560" y2="560" x1="3248" />
        </branch>
        <branch name="XLXN_57">
            <wire x2="3248" y1="656" y2="656" x1="2720" />
            <wire x2="3248" y1="656" y2="720" x1="3248" />
            <wire x2="3776" y1="720" y2="720" x1="3248" />
        </branch>
        <branch name="XLXN_58">
            <wire x2="3232" y1="720" y2="720" x1="2720" />
            <wire x2="3232" y1="720" y2="864" x1="3232" />
            <wire x2="3776" y1="864" y2="864" x1="3232" />
        </branch>
        <branch name="q0">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="4224" y="528" type="branch" />
            <wire x2="4224" y1="528" y2="528" x1="4032" />
            <wire x2="4304" y1="528" y2="528" x1="4224" />
        </branch>
        <branch name="q1">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="4208" y="688" type="branch" />
            <wire x2="4208" y1="688" y2="688" x1="4032" />
            <wire x2="4304" y1="688" y2="688" x1="4208" />
        </branch>
        <branch name="q2">
            <attrtext style="alignment:SOFT-BCENTER;fontsize:28;fontname:Arial" attrname="Name" x="4224" y="832" type="branch" />
            <wire x2="4224" y1="832" y2="832" x1="4032" />
            <wire x2="4304" y1="832" y2="832" x1="4224" />
        </branch>
    </sheet>
</drawing>