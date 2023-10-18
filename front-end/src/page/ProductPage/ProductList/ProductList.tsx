import './style/product-list.scss';

import useRequest from 'common/customHook/useRequest';
import Loading from 'component/Loading';
import _ from 'lodash';
import { useEffect } from 'react';
import { useMergeState } from 'use-merge-state';
import AppUtil from 'util/AppUtil';

import { ProductBox } from '../ProductBox/ProductBox';
import { Type_Product_Api } from './interface/ProductInterface';

interface State {
    data?: Array<Type_Product_Api>,
    loading: boolean
}

const ProductList = () => {
    const { get } = useRequest();
    const [state, setState] = useMergeState<State>({
        data: [],
        loading: true
    });

    useEffect(() => {
        loadData();
    }, []);

    const loadData = () => {
        setState({
            loading: false,
            data: []
        });
    };

    if (state.loading) {
        return <Loading />;
    }

    return (
        <div className='product-list grid sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 2xl:grid-cols-5 gap-6'>
            {_.map(state.data, (product) => {
                return <div className='wrap-content-product'>
                    <ProductBox nameProduct={_.get(product, 'name', '')}
                        price={AppUtil.GetShowMoney(product.price)}
                        shortInfo={_.get(product, 'desc', 'Đang cập nhật...')} />
                </div>;

            })}
        </div>
    );
};
export default ProductList;