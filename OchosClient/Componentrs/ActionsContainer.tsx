import React, { Component } from 'react';
import { Alert, Button, Text, View } from 'react-native';

class ActionsContainer extends Component {
    public devices: string[] = [
        "test1",
        "test2"
    ];
    public render() {
        return (
            <View>
                {
                    this.devices.map(d => {
                        return (
                            <Button
                                title={d}
                                onPress={() => Alert.prompt('Button pressed', d, undefined, 'secure-text', "test")}
                            />
                        );
                    })
                }
            </View>
        );
    }
}

export default ActionsContainer;