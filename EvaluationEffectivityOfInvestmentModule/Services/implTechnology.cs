using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public class implTechnology : Technology
    {
    int n,v,capacity;
    double p,t,Weff,Wnorm;
    public implTechnology(int n, double p, double t, int v, int capacity, double weff, double wnorm)
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

    @Override
    public double getP()
    {
        return p;
    }

    @Override
    public double getT()
    {
        return t;
    }

    @Override
    public int getV()
    {
        return v;
    }

    @Override
    public int getCapacity()
    {
        return capacity;
    }

    @Override
    public double getWeff()
    {
        return Weff;
    }

    @Override
    public double getWnorm()
    {
        return Wnorm;
    }
}

}