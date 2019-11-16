/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * Generated with the TypeScript template
 * https://github.com/react-native-community/react-native-template-typescript
 *
 * @format
 */
import React from 'react';
import { SafeAreaView, StyleSheet, ScrollView, View, Text, StatusBar, } from 'react-native';
import { Header, LearnMoreLinks, Colors, DebugInstructions, ReloadInstructions, } from 'react-native/Libraries/NewAppScreen';
const App = () => {
    // const usingHermes = typeof HermesInternal === 'object' && HermesInternal !== null;
    return (React.createElement(React.Fragment, null,
        React.createElement(StatusBar, { barStyle: "dark-content" }),
        React.createElement(SafeAreaView, null,
            React.createElement(ScrollView, { contentInsetAdjustmentBehavior: "automatic", style: styles.scrollView },
                React.createElement(Header, null),
                React.createElement(View, { style: styles.body },
                    React.createElement(View, { style: styles.sectionContainer },
                        React.createElement(Text, { style: styles.sectionTitle }, "Step One"),
                        React.createElement(Text, { style: styles.sectionDescription },
                            "Edit ",
                            React.createElement(Text, { style: styles.highlight }, "App.tsx"),
                            " to change this screen and then come back to see your edits.")),
                    React.createElement(View, { style: styles.sectionContainer },
                        React.createElement(Text, { style: styles.sectionTitle }, "See Your Changes"),
                        React.createElement(Text, { style: styles.sectionDescription },
                            React.createElement(ReloadInstructions, null))),
                    React.createElement(View, { style: styles.sectionContainer },
                        React.createElement(Text, { style: styles.sectionTitle }, "Debug"),
                        React.createElement(Text, { style: styles.sectionDescription },
                            React.createElement(DebugInstructions, null))),
                    React.createElement(View, { style: styles.sectionContainer },
                        React.createElement(Text, { style: styles.sectionTitle }, "Learn More"),
                        React.createElement(Text, { style: styles.sectionDescription }, "Read the docs to discover what to do next:")),
                    React.createElement(LearnMoreLinks, null))))));
};
const styles = StyleSheet.create({
    scrollView: {
        backgroundColor: Colors.lighter,
    },
    engine: {
        position: 'absolute',
        right: 0,
    },
    body: {
        backgroundColor: Colors.white,
    },
    sectionContainer: {
        marginTop: 32,
        paddingHorizontal: 24,
    },
    sectionTitle: {
        fontSize: 24,
        fontWeight: '600',
        color: Colors.black,
    },
    sectionDescription: {
        marginTop: 8,
        fontSize: 18,
        fontWeight: '400',
        color: Colors.dark,
    },
    highlight: {
        fontWeight: '700',
    },
    footer: {
        color: Colors.dark,
        fontSize: 12,
        fontWeight: '600',
        padding: 4,
        paddingRight: 12,
        textAlign: 'right',
    },
});
export default App;
//# sourceMappingURL=App.js.map