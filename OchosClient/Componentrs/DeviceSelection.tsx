import { Picker } from '@react-native-picker/picker';
import React, { Component, useState } from 'react';
import { Alert, Button, StyleSheet, Text, View } from 'react-native';

class DeviceSelection extends Component {
    public devices: string[] = [
        "",
        "test1",
        "test2"
    ];
    public selectedValue: string = '';

    public get options(): any[] {
        return this.devices.map(d => {
            return <Picker.Item label={d} value={d} key={d} />
        });
    }
    constructor(props: any) {
        super(props);
        this.state = this;
    }

    public render() {
        const styles = this.generateStyles();
        return (
            <View style={styles.container}>
                <Text>Select device:</Text>
                <Picker
                    selectedValue={this.selectedValue}
                    onValueChange={(newValue: any, actionMeta: any) => this.setSelectedValue(newValue)}
                >
                    {this.options}
                </Picker>
                <Button
                    disabled={this.selectedValue.length == 0}
                    title={"Confirm " + this.selectedValue}
                    onPress={() => Alert.alert('Confirmed :D')}
                />
            </View>
        );
    }
    public generateStyles() {
        const styles = StyleSheet.create({
            container: {
                margin: 50,
                marginTop: "81%",
                marginBottom: "81%",
                display: 'flex',
                justifyContent: 'center',
                // height: '100%'
            }
        });
        return styles;
    }

    public setSelectedValue(newValue: any): void {
        this.selectedValue = newValue;
        this.setState(this);
    }
}

export default DeviceSelection;