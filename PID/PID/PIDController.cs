using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PID
{
    public class PIDController
    {
        //PID参数
        public double Kp { get; set; }
        public double Ki { get; set; }
        public double Kd { get; set; }

        //内部变量
        private double _integral;//积分项
        private double _lastError;//上次误差
        private double _integralMax;//积分限幅最大值
        private double _integralMin;//积分限幅最小值

        public PIDController(double kp, double ki, double kd, double integralMax = Double.MaxValue, double integralMin = Double.MinValue)
        {
            Kp = kp;
            Ki = ki;
            Kd = kd;
            _integral = 0;
            _lastError = 0;
            _integralMax = integralMax;
            _integralMin = integralMin;
        }

        //计算控制输出方法
        public double Compute(double setPoint,double pv,double dt)
        {
            //误差计算
            double error = setPoint - dt;
            //计算积分项并进行积分限幅
            _integral += error * dt;
            if (_integral > _integralMax) _integral = _integralMax;
            if (_integral<_integralMin) _integral = _integralMin;
            //计算微分项
            double derivative = (error - _lastError) / dt;
            //PID输出
            double outPut = Kp * error + Ki * _integral + Kd * derivative;
            //保存本次误差
            _lastError = error;
            return outPut;
        }
        // 定义被控对象的传递函数参数
        // 这里采用一阶惯性环节加纯滞后模型：G(s) = K / (T * s + 1) * e^(-Ls)
        // 为简化，纯滞后项忽略，模型为：G(s) = K / (T * s + 1)
        // K：增益，T：时间常数,dt：仿真步长
        public double ProcessModel(double input, double pv, double K, double T, double dt)
        {
            // 使用离散化的一阶惯性环节模型
            // pv为上一次的过程值，input为当前控制输入
            double a = dt / (T + dt);
            double pv_new = (1 - a) * pv + a * K * input;
            return pv_new;
        }
    }
}
