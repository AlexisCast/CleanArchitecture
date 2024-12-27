﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ApplicationLayer
{
    public interface IPresenter<TEntity, TOutput> // Generic of input and output
    {
        public IEnumerable<TOutput> Present(IEnumerable<TEntity> data);
    }
}
