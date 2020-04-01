package edu.brown.mpmhplugin;

public class MPMHPlugin
{
    static {
        System.loadLibrary("mediapipe_jni");
        System.loadLibrary("opencv_java3");
    }

    public String test() {
        return "Test String from ARR";
    }
}