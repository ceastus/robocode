//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.8000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace robocode.control.snapshot {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ITurnSnapshot {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Lrobocode/control/snapshot/IRobotSnapshot;")]
        robocode.control.snapshot.IRobotSnapshot[] getRobots();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Lrobocode/control/snapshot/IBulletSnapshot;")]
        robocode.control.snapshot.IBulletSnapshot[] getBullets();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getTPS();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getRound();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getTurn();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Lrobocode/control/snapshot/IScoreSnapshot;")]
        robocode.control.snapshot.IScoreSnapshot[] getSortedTeamScores();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Lrobocode/control/snapshot/IScoreSnapshot;")]
        robocode.control.snapshot.IScoreSnapshot[] getIndexedTeamScores();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ITurnSnapshot_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.snapshot.@__ITurnSnapshot.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::robocode.control.snapshot.ITurnSnapshot), typeof(global::robocode.control.snapshot.ITurnSnapshot_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::robocode.control.snapshot.ITurnSnapshot), typeof(global::robocode.control.snapshot.ITurnSnapshot_))]
    internal sealed partial class @__ITurnSnapshot : global::java.lang.Object, global::robocode.control.snapshot.ITurnSnapshot {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRobots0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getBullets1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getTPS2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRound3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getTurn4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getSortedTeamScores5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getIndexedTeamScores6;
        
        private @__ITurnSnapshot(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.snapshot.@__ITurnSnapshot.staticClass = @__class;
            global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getRobots0 = @__env.GetMethodID(global::robocode.control.snapshot.@__ITurnSnapshot.staticClass, "getRobots", "()[Lrobocode/control/snapshot/IRobotSnapshot;");
            global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getBullets1 = @__env.GetMethodID(global::robocode.control.snapshot.@__ITurnSnapshot.staticClass, "getBullets", "()[Lrobocode/control/snapshot/IBulletSnapshot;");
            global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getTPS2 = @__env.GetMethodID(global::robocode.control.snapshot.@__ITurnSnapshot.staticClass, "getTPS", "()I");
            global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getRound3 = @__env.GetMethodID(global::robocode.control.snapshot.@__ITurnSnapshot.staticClass, "getRound", "()I");
            global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getTurn4 = @__env.GetMethodID(global::robocode.control.snapshot.@__ITurnSnapshot.staticClass, "getTurn", "()I");
            global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getSortedTeamScores5 = @__env.GetMethodID(global::robocode.control.snapshot.@__ITurnSnapshot.staticClass, "getSortedTeamScores", "()[Lrobocode/control/snapshot/IScoreSnapshot;");
            global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getIndexedTeamScores6 = @__env.GetMethodID(global::robocode.control.snapshot.@__ITurnSnapshot.staticClass, "getIndexedTeamScores", "()[Lrobocode/control/snapshot/IScoreSnapshot;");
        }
        
        public robocode.control.snapshot.IRobotSnapshot[] getRobots() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<robocode.control.snapshot.IRobotSnapshot[], global::robocode.control.snapshot.IRobotSnapshot>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getRobots0));
            }
        }
        
        public robocode.control.snapshot.IBulletSnapshot[] getBullets() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<robocode.control.snapshot.IBulletSnapshot[], global::robocode.control.snapshot.IBulletSnapshot>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getBullets1));
            }
        }
        
        public int getTPS() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getTPS2)));
            }
        }
        
        public int getRound() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getRound3)));
            }
        }
        
        public int getTurn() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getTurn4)));
            }
        }
        
        public robocode.control.snapshot.IScoreSnapshot[] getSortedTeamScores() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<robocode.control.snapshot.IScoreSnapshot[], global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getSortedTeamScores5));
            }
        }
        
        public robocode.control.snapshot.IScoreSnapshot[] getIndexedTeamScores() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<robocode.control.snapshot.IScoreSnapshot[], global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.snapshot.@__ITurnSnapshot.j4n_getIndexedTeamScores6));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ITurnSnapshot);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRobots", "getRobots0", "()[Lrobocode/control/snapshot/IRobotSnapshot;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getBullets", "getBullets1", "()[Lrobocode/control/snapshot/IBulletSnapshot;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTPS", "getTPS2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRound", "getRound3", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTurn", "getTurn4", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getSortedTeamScores", "getSortedTeamScores5", "()[Lrobocode/control/snapshot/IScoreSnapshot;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getIndexedTeamScores", "getIndexedTeamScores6", "()[Lrobocode/control/snapshot/IScoreSnapshot;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getRobots0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Lrobocode/control/snapshot/IRobotSnapshot;
            // ()[Lrobocode/control/snapshot/IRobotSnapshot;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::robocode.control.snapshot.ITurnSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.ITurnSnapshot>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<robocode.control.snapshot.IRobotSnapshot[], global::robocode.control.snapshot.IRobotSnapshot>(@__env, @__real.getRobots());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getBullets1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Lrobocode/control/snapshot/IBulletSnapshot;
            // ()[Lrobocode/control/snapshot/IBulletSnapshot;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::robocode.control.snapshot.ITurnSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.ITurnSnapshot>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<robocode.control.snapshot.IBulletSnapshot[], global::robocode.control.snapshot.IBulletSnapshot>(@__env, @__real.getBullets());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getTPS2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::robocode.control.snapshot.ITurnSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.ITurnSnapshot>(@__env, @__obj);
            @__return = ((int)(@__real.getTPS()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getRound3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::robocode.control.snapshot.ITurnSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.ITurnSnapshot>(@__env, @__obj);
            @__return = ((int)(@__real.getRound()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getTurn4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::robocode.control.snapshot.ITurnSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.ITurnSnapshot>(@__env, @__obj);
            @__return = ((int)(@__real.getTurn()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getSortedTeamScores5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Lrobocode/control/snapshot/IScoreSnapshot;
            // ()[Lrobocode/control/snapshot/IScoreSnapshot;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::robocode.control.snapshot.ITurnSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.ITurnSnapshot>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<robocode.control.snapshot.IScoreSnapshot[], global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__real.getSortedTeamScores());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getIndexedTeamScores6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Lrobocode/control/snapshot/IScoreSnapshot;
            // ()[Lrobocode/control/snapshot/IScoreSnapshot;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::robocode.control.snapshot.ITurnSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.ITurnSnapshot>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<robocode.control.snapshot.IScoreSnapshot[], global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__real.getIndexedTeamScores());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.snapshot.@__ITurnSnapshot(@__env);
            }
        }
    }
    #endregion
}
