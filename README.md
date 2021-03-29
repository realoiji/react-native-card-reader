
# react-native-card-reader

## Getting started

`$ npm install react-native-card-reader --save`

### Mostly automatic installation

`$ react-native link react-native-card-reader`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-card-reader` and add `RNCardReader.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCardReader.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNCardReaderPackage;` to the imports at the top of the file
  - Add `new RNCardReaderPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-card-reader'
  	project(':react-native-card-reader').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-card-reader/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-card-reader')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCardReader.sln` in `node_modules/react-native-card-reader/windows/RNCardReader.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Card.Reader.RNCardReader;` to the usings at the top of the file
  - Add `new RNCardReaderPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCardReader from 'react-native-card-reader';

// TODO: What to do with the module?
RNCardReader;
```
  