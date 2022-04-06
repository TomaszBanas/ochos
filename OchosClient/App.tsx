import React from 'react';
import { SafeAreaView, ScrollView, StatusBar, StyleSheet, useColorScheme, View, } from 'react-native';

import { Colors } from 'react-native/Libraries/NewAppScreen';
import DeviceSelection from './Componentrs/DeviceSelection';


const App = () => {
  return (
    <SafeAreaView style={styles.backgroundStyle}>
      <StatusBar barStyle={'dark-content'} />
      <ScrollView style={styles.backgroundStyle}>
        <View style={styles.viewContainer}>
            <DeviceSelection/>
        </View>
      </ScrollView>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  sectionContainer: {
    height: '100%',
  },
  backgroundStyle: {
    backgroundColor: Colors.white,
    height: '100%',
    width: '100%',
  },
  viewContainer: {
    height: '100%',
    width: '100%',
    backgroundColor: Colors.white,
  },
  sectionTitle: {
    fontSize: 24,
    fontWeight: '600',
  },
  sectionDescription: {
    marginTop: 8,
    fontSize: 18,
    fontWeight: '400',
  },
  highlight: {
    fontWeight: '700',
    height: '100%',
  },
});

export default App;
