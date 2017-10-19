using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public class ImplTechnology : Technology
    {
    int n,v,capacity;
    double p,t,Weff,Wnorm;
    public ImplTechnology(int n, double p, double t, int v, int capacity, double weff, double wnorm)
    {
        this.n = n;
        this.p = p;
        this.t = t;
        this.v = v;
        this.capacity = capacity;
        this.Weff = weff;
        this.Wnorm = wnorm;
    }
    public int getN()
    {
        return n;
    }

   
    public double getP()
    {
        return p;
    }

    public double getT()
    {
        return t;
    }

    
    public int getV()
    {
        return v;
    }

    
    public int getCapacity()
    {
        return capacity;
    }

    
    public double getWeff()
    {
        return Weff;
    }

    
    public double getWnorm()
    {
        return Wnorm;
    }
}

}